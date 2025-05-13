using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ProtoHSM.Cajas;
using ProtoHSM.Farmacia;
using ProtoHSM.Models;

namespace ProtoHSM
{
    public class Controller
    {
        private int idPaciente;       
        
        public string connectionString = "Server=localhost\\HSM;Database=HospitalSanMarcos;User Id=sa;Password=476362;TrustServerCertificate=True;";
       
        public Usuario UsuarioActual { get; private set; }
        public void IniciarSesion(Usuario usuario)
        {
            UsuarioActual = usuario;
        }

        public void CerrarSesion()
        {
            UsuarioActual = null;
        }

        public Controller()
        {

        }

        public List<PacienteComboDTO> ObtenerPacientesDTO()
        {
            var lista = new List<PacienteComboDTO>();
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.usp_GetPacientesDTO", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lista.Add(new PacienteComboDTO
                {
                    PacienteID = rdr.GetInt32(rdr.GetOrdinal("PacienteID")),
                    Nombre = rdr.GetString(rdr.GetOrdinal("Nombre")),
                    CURP = rdr.GetString(rdr.GetOrdinal("CURP")),   // <— mapeo
                });
            }
            return lista;
        }

        public List<PacienteComboDTO> ObtenerPacientesDTOActivos()
        {
            var lista = new List<PacienteComboDTO>();
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.usp_GetPacientesDTOActivos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lista.Add(new PacienteComboDTO
                {
                    PacienteID = rdr.GetInt32(rdr.GetOrdinal("PacienteID")),
                    Nombre = rdr.GetString(rdr.GetOrdinal("Nombre")),
                    CURP = rdr.GetString(rdr.GetOrdinal("CURP")),   // <— mapeo
                });
            }
            return lista;
        }

        public List<ext> ObtenerExtensiones()
        {
            var lista = new List<ext>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerExtensiones", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ext
                        {                            
                            Extension = reader.GetString(reader.GetOrdinal("Extension")),
                            Puesto = reader.GetString(reader.GetOrdinal("Puesto"))
                        });
                    }
                }
            }

            return lista;
        }

        public List<Paquete> ObtenerPaquetes()
        {
            var lista = new List<Paquete>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerPaquetesBasico", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Paquete
                        {
                            
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                            Categoria = reader["Categoria"] as string,
                            CostoTotal = reader.GetDecimal(reader.GetOrdinal("CostoTotal"))
                        });
                    }
                }
            }

            return lista;
        }

        public DataTable CargarSolicitudesPendientes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("sp_ObtenerSolicitudesPendientesFarmacia", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;              
            }
        }

        public SugerenciaLoteDTO ObtenerSugerenciaParaDetalle(int detalleID)
        {
            var dto = new SugerenciaLoteDTO();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerDetalleSolicitudConSugerencia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DetalleID", detalleID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dto.DetalleID = reader.GetInt32(0);
                        dto.Cantidad = reader.GetInt32(1);
                        dto.Medicamento = reader.GetString(2);
                        dto.LoteID = reader.GetInt32(3);
                        dto.NumeroLote = reader.GetString(4);
                        dto.FechaCaducidad = reader.GetDateTime(5);
                        dto.Almacen = reader.GetString(6);
                        dto.StockDisponible = reader.GetInt32(7);
                    }
                }
            }

            return dto;
        }

        public List<MedicoComboDTO> ObtenerMedicosDTO()
        {
            var lista = new List<MedicoComboDTO>();

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("dbo.usp_GetMedicosConNombreCompleto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new MedicoComboDTO
                        {
                            MedicoID = reader.GetInt32(reader.GetOrdinal("MedicoID")),
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                        });
                    }
                }
            }

            return lista;
        }

        public List<Medico> ObtenerMedicos()
        {
            var lista = new List<Medico>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerMedicos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Medico
                        {
                            ID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Especialidad = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Telefono = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            
                        });
                    }
                }
            }

            return lista;
        }

        public List<Paciente> ObtenerPacientesActivos()
        {
            var lista = new List<Paciente>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerPacientesActivos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Paciente
                        {
                            PacienteID = reader.GetInt32(0),
                            Nombres = reader.GetString(1),
                            
                         

                        });
                    }
                }
            }

            return lista;
        }

        public List<Medico> ObtenerMedicosNombre()
        {
            List<Medico> medicos = new List<Medico>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerNombresMedicos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        medicos.Add(new Medico
                        {
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                            // Opcional: puedes capturar MedicoID si quieres
                        });
                    }
                }
            }

            return medicos;
        }

        public List<LoteSugeridoDTO> ObtenerLotesSugeridos(int medicamentoID)
        {
            var lista = new List<LoteSugeridoDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SugerenciaLotesPorMedicamento", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new LoteSugeridoDTO
                        {
                            LoteID = reader.GetInt32(0),
                            NumeroLote = reader.GetString(1),
                            FechaCaducidad = reader.GetDateTime(2),
                            CantidadDisponible = reader.GetInt32(3),
                            Almacen = reader.GetString(4)
                        });
                    }
                }
            }

            return lista;
        }

        public SolicitudFarmaciaDTO ObtenerDetalleInsumoPorID(int detalleID)
        {
            var dto = new SolicitudFarmaciaDTO();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerDetalleSolicitudFarmacia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DetalleID", detalleID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dto.DetalleID = reader.GetInt32(reader.GetOrdinal("DetalleID"));
                        dto.FechaSolicitud = reader.GetDateTime(reader.GetOrdinal("FechaSolicitud"));
                        dto.Paciente = reader.GetString(reader.GetOrdinal("NombrePaciente"));
                        dto.Cama = reader.IsDBNull(reader.GetOrdinal("Cama")) ? "N/A" : reader.GetString(reader.GetOrdinal("Cama"));
                        dto.Medico = reader.IsDBNull(reader.GetOrdinal("MedicoResponsable")) ? "Sin asignar" : reader.GetString(reader.GetOrdinal("MedicoResponsable"));
                        dto.Enfermera = reader.GetString(reader.GetOrdinal("Enfermera"));
                        dto.Medicamento = reader.GetString(reader.GetOrdinal("Medicamento"));
                        dto.Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad"));
                        dto.Estado = reader.GetString(reader.GetOrdinal("Estado"));
                    }
                }
            }

            return dto;
        }

        public (int VisitaID, int CamaID) RegistrarUrgencia(int pacienteID, int nivelTriage, string medico)
        {
            int visitaID = 0;
            int camaID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarUrgenciaYAsignarCama", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PacienteID", pacienteID);
                cmd.Parameters.AddWithValue("@NivelTriage", nivelTriage);
                cmd.Parameters.AddWithValue("@UsuarioID", UsuarioActual.UsuarioID);
                cmd.Parameters.AddWithValue("@MedicoResponsable", medico);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        visitaID = reader.GetInt32(0);
                        camaID = reader.GetInt32(1);
                    }
                }
            }

            return (visitaID, camaID);
        }

        public void loadNuevoPaciente()
        {
            nuevoPaciente pacienteNuevo = new nuevoPaciente(this, UsuarioActual);
            pacienteNuevo.ShowDialog();
        }

        public int RegistrarPaciente(Paciente paciente, int usuarioID)
        {
            int pacienteID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarPacienteSolo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombres", paciente.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", paciente.Apellidos);
                cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                cmd.Parameters.AddWithValue("@CURP", paciente.CURP);
                cmd.Parameters.AddWithValue("@Nacionalidad", paciente.Nacionalidad);
                cmd.Parameters.AddWithValue("@Calle", paciente.Calle);
                cmd.Parameters.AddWithValue("@Numero", paciente.Numero);
                cmd.Parameters.AddWithValue("@Colonia", paciente.Colonia);
                cmd.Parameters.AddWithValue("@CP", paciente.CP);
                cmd.Parameters.AddWithValue("@Estado", paciente.Estado);
                cmd.Parameters.AddWithValue("@Municipio", paciente.Municipio);
                cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("@Escolaridad", paciente.Escolaridad);
                cmd.Parameters.AddWithValue("@EstadoCivil", paciente.EstadoCivil);
                cmd.Parameters.AddWithValue("@Ocupacion", paciente.Ocupacion);
                cmd.Parameters.AddWithValue("@Religion", paciente.Religion);
                cmd.Parameters.AddWithValue("@TratamientosExistentes", paciente.TratamientosExistentes);
                cmd.Parameters.AddWithValue("@AlergiasMedicamentos", paciente.AlergiasMedicamentos);
                cmd.Parameters.AddWithValue("@AlergiasAlimentos", paciente.AlergiasAlimentos);
                cmd.Parameters.AddWithValue("@AlergiasAmbiente", paciente.AlergiasAmbiente);
                cmd.Parameters.AddWithValue("@AlergiasMaterial", paciente.AlergiasMaterial);
                cmd.Parameters.AddWithValue("@DificultadHabla", paciente.DificultadHabla);
                cmd.Parameters.AddWithValue("@DificultadAuditiva", paciente.DificultadAuditiva);
                cmd.Parameters.AddWithValue("@DificultadVisual", paciente.DificultadVisual);
                cmd.Parameters.AddWithValue("@DificultadMental", paciente.DificultadMental);
                cmd.Parameters.AddWithValue("@DificultadPsicologica", paciente.DificultadPsicologica);
                cmd.Parameters.AddWithValue("@DificultadMotriz", paciente.DificultadMotriz);
                cmd.Parameters.AddWithValue("@UsaEquipoAuditivo", paciente.UsaEquipoAuditivo);
                cmd.Parameters.AddWithValue("@UsaLentes", paciente.UsaLentes);
                //cmd.Parameters.AddWithValue("@AseguradoraID", paciente.AseguradoraID );
                cmd.Parameters.AddWithValue("@NumeroPoliza", paciente.NumeroPoliza );
                cmd.Parameters.AddWithValue("@CreatedBy", usuarioID);

                conn.Open();
                pacienteID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return pacienteID;
        }

        public void RegistrarFamiliar(FamiliarPaciente familiar)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarResponsablePaciente", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PacienteID", familiar.PacienteID);
                cmd.Parameters.AddWithValue("@NombreCompleto", familiar.Nombre);
                cmd.Parameters.AddWithValue("@Parentesco", familiar.Parentesco);
                cmd.Parameters.AddWithValue("@Domicilio", familiar.Domicilio);
                cmd.Parameters.AddWithValue("@Telefono", familiar.Telefono);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool CurpExiste(string curp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Pacientes WHERE CURP = @CURP", conn);
                cmd.Parameters.AddWithValue("@CURP", curp);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public FamiliarPaciente ObtenerResponsablePorPaciente(int pacienteID)
        {
            FamiliarPaciente familiar = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerResponsablePorPaciente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PacienteID", pacienteID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        familiar = new FamiliarPaciente
                        {
                            PacienteID = reader.GetInt32(reader.GetOrdinal("PacienteID")),
                            Nombre = reader.GetString(reader.GetOrdinal("NombreCompleto")),
                            Parentesco = reader.GetString(reader.GetOrdinal("Parentesco")),
                            Domicilio = reader.GetString(reader.GetOrdinal("Domicilio")),
                            Telefono = reader.GetString(reader.GetOrdinal("Telefono"))
                        };
                    }
                }
            }

            return familiar;
        }

        public void RegistrarMedico(Medico medico)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarMedico", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", medico.Nombre);
                cmd.Parameters.AddWithValue("@Especialidad", string.IsNullOrEmpty(medico.Especialidad) ? (object)DBNull.Value : medico.Especialidad);
                cmd.Parameters.AddWithValue("@CedulaProfesional", medico.CedulaProfesional);
                cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(medico.Telefono) ? (object)DBNull.Value : medico.Telefono);
                cmd.Parameters.AddWithValue("@CreatedBy", UsuarioActual.UsuarioID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<CamaDisponibleDTO> ObtenerCamasDisponibles(int tipoCamaID)
        {
            var lista = new List<CamaDisponibleDTO>();

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("dbo.sp_ObtenerCamasDisponibles", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoCamaID", tipoCamaID);

                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lista.Add(new CamaDisponibleDTO
                        {
                            CamaID = rdr.GetInt32(rdr.GetOrdinal("CamaID")),
                            NumeroCama = rdr.GetString(rdr.GetOrdinal("NumeroCama"))
                        });
                    }
                }
            }

            return lista;
        }

        public int RegistrarVisita(
     int pacienteID,
     string tipoVisita,
     string diagnostico,
     string procedimiento,
     int createdBy,
     int medicoID,
     string cama
 )
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("sp_RegistrarVisita", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@PacienteID", pacienteID);
            cmd.Parameters.AddWithValue("@TipoVisita", tipoVisita);
            cmd.Parameters.AddWithValue("@Diagnostico", (object)diagnostico ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Procedimiento", (object)procedimiento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Cama", (object)cama ?? DBNull.Value);

            // Usa el parámetro que recibes en lugar de UsuarioActual
            cmd.Parameters.AddWithValue("@CreatedBy", createdBy);
            cmd.Parameters.AddWithValue("@MedicoID", medicoID);

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }



        public string ObtenerCURPPaciente(int pacienteID)
        {
            string curp = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT CURP FROM Pacientes WHERE PacienteID = @PacienteID", conn);
                cmd.Parameters.AddWithValue("@PacienteID", pacienteID);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    curp = result.ToString();
            }

            return curp;
        }

        public DataTable ObtenerPacientesUltimaVisita()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerPacientesUltimaVisita", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public (Paciente paciente, ResponsablePaciente familiar)
     ObtenerPacienteCompletoPorID(int pacienteID)
        {
            Paciente paciente = null;
            ResponsablePaciente familiar = null;

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(@"
        SELECT 
            P.PacienteID, P.Nombres, P.Apellidos, P.CURP, P.Telefono,
            P.FechaNacimiento, P.Nacionalidad,
            P.Calle, P.Numero, P.Colonia, P.Estado, P.CP, P.Municipio,
            P.Sexo, P.EstadoCivil, P.Escolaridad, P.Ocupacion,
            P.TratamientosExistentes, P.UsaLentes, P.UsaEquipoAuditivo,
            P.DificultadHabla, P.DificultadVisual, P.DificultadAuditiva,
            P.DificultadMotriz, P.DificultadMental, P.DificultadPsicologica,
            P.AlergiaMedicamentos, P.AlergiaAlimentos, P.AlergiaAmbiente, P.AlergiaMaterial,
            R.ResponsableID, R.NombreCompleto AS NombreResponsable, R.Parentesco,
            R.Telefono AS TelResponsable, R.Domicilio AS DomicilioResponsable
        FROM dbo.Pacientes P
        LEFT JOIN dbo.ResponsablesPaciente R
          ON P.PacienteID = R.PacienteID
        WHERE P.PacienteID = @PacienteID", conn)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@PacienteID", pacienteID);
            conn.Open();

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return (null, null);

            bool SafeBool(string col)
                => !reader.IsDBNull(reader.GetOrdinal(col))
                   && reader.GetBoolean(reader.GetOrdinal(col));

            paciente = new Paciente
            {
                PacienteID = reader.GetInt32("PacienteID"),
                Nombres = reader.GetString("Nombres"),
                Apellidos = reader.GetString("Apellidos"),
                CURP = reader.GetString("CURP"),
                Telefono = reader.GetString("Telefono"),
                FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                Nacionalidad = reader.GetString("Nacionalidad"),
                Calle = reader.GetString("Calle"),
                Numero = reader.GetString("Numero"),
                Colonia = reader.GetString("Colonia"),
                Estado = reader.GetString("Estado"),
                CP = reader.GetString("CP"),
                Municipio = reader.GetString("Municipio"),
                Sexo = SafeBool("Sexo"), 
                EstadoCivil = reader.GetString("EstadoCivil"),
                Escolaridad = reader.GetString("Escolaridad"),               
                Ocupacion = reader.GetString("Ocupacion"),
                TratamientosExistentes = reader.GetString("TratamientosExistentes"),
                UsaLentes = SafeBool("UsaLentes"),
                UsaEquipoAuditivo = SafeBool("UsaEquipoAuditivo"),
                DificultadHabla = SafeBool("DificultadHabla"),
                DificultadVisual = SafeBool("DificultadVisual"),
                DificultadAuditiva = SafeBool("DificultadAuditiva"),
                DificultadMotriz = SafeBool("DificultadMotriz"),
                DificultadMental = SafeBool("DificultadMental"),
                DificultadPsicologica = SafeBool("DificultadPsicologica"),
                AlergiasMedicamentos = reader.GetString("AlergiaMedicamentos"),
                AlergiasAlimentos = reader.GetString("AlergiaAlimentos"),
                AlergiasAmbiente = reader.GetString("AlergiaAmbiente"),
                AlergiasMaterial = reader.GetString("AlergiaMaterial"),
            };

            // Responsable opcional
            if (!reader.IsDBNull(reader.GetOrdinal("NombreResponsable")))
            {
                familiar = new ResponsablePaciente
                {
                    ResponsableID = reader.GetInt32(reader.GetOrdinal("ResponsableID")),
                    NombreCompleto = reader.GetString(reader.GetOrdinal("NombreResponsable")),
                    Parentesco = reader.GetString(reader.GetOrdinal("Parentesco")),
                    Telefono = reader.GetString(reader.GetOrdinal("TelResponsable")),
                    Domicilio = reader.GetString(reader.GetOrdinal("DomicilioResponsable"))
                };
            }

            return (paciente, familiar);
        }



        public bool ActualizarPacienteYResponsable(Paciente paciente, ResponsablePaciente familiar)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarPacienteYResponsable", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros existentes
                cmd.Parameters.AddWithValue("@PacienteID", paciente.PacienteID);
                cmd.Parameters.AddWithValue("@Nombres", paciente.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", paciente.Apellidos);
                cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("@Nacionalidad", paciente.Nacionalidad);
                cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Calle", paciente.Calle);
                cmd.Parameters.AddWithValue("@Numero", paciente.Numero);
                cmd.Parameters.AddWithValue("@Colonia", paciente.Colonia);
                cmd.Parameters.AddWithValue("@Estado", paciente.Estado);
                cmd.Parameters.AddWithValue("@CP", paciente.CP);
                cmd.Parameters.AddWithValue("@Municipio", paciente.Municipio);
                cmd.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                cmd.Parameters.AddWithValue("@EstadoCivil", paciente.EstadoCivil);
                cmd.Parameters.AddWithValue("@Escolaridad", paciente.Escolaridad);
                cmd.Parameters.AddWithValue("@Ocupacion", paciente.Ocupacion);
                cmd.Parameters.AddWithValue("@TratamientosExistentes", paciente.TratamientosExistentes);
                cmd.Parameters.AddWithValue("@AlergiasMedicamentos", paciente.AlergiasMedicamentos);
                cmd.Parameters.AddWithValue("@AlergiasAlimentos", paciente.AlergiasAlimentos);
                cmd.Parameters.AddWithValue("@AlergiasAmbiente", paciente.AlergiasAmbiente);
                cmd.Parameters.AddWithValue("@AlergiasMaterial", paciente.AlergiasMaterial);

                // Nuevos parámetros booleanos (BIT)
                cmd.Parameters.AddWithValue("@DificultadHabla", paciente.DificultadHabla);
                cmd.Parameters.AddWithValue("@DificultadAuditiva", paciente.DificultadAuditiva);
                cmd.Parameters.AddWithValue("@DificultadVisual", paciente.DificultadVisual);
                cmd.Parameters.AddWithValue("@DificultadMental", paciente.DificultadMental);
                cmd.Parameters.AddWithValue("@DificultadPsicologica", paciente.DificultadPsicologica);
                cmd.Parameters.AddWithValue("@DificultadMotriz", paciente.DificultadMotriz);
                cmd.Parameters.AddWithValue("@UsaEquipoAuditivo", paciente.UsaEquipoAuditivo);
                cmd.Parameters.AddWithValue("@UsaLentes", paciente.UsaLentes);

                // Parámetros de familiar
                cmd.Parameters.AddWithValue("@NombreResponsable", familiar?.NombreCompleto);
                cmd.Parameters.AddWithValue("@Parentesco", familiar?.Parentesco);
                cmd.Parameters.AddWithValue("@TelefonoResponsable", familiar?.Telefono);
                cmd.Parameters.AddWithValue("@DomicilioResponsable", familiar?.Domicilio);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
            }
        }

        public int RegistrarProveedor(Proveedor proveedor)
        {
            if (proveedor == null)
                throw new ArgumentNullException(nameof(proveedor));

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.sp_RegistrarProveedor", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
            cmd.Parameters.AddWithValue("@RFC", (object)proveedor.RFC ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", (object)proveedor.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)proveedor.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Calle", (object)proveedor.Calle ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@NumeroExt", (object)proveedor.NumExt ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@NumeroInt", (object)proveedor.NumInt ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Colonia", (object)proveedor.Colonia ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ZipCode", proveedor.ZipCode);

            conn.Open();
            // ExecuteScalar devuelve el ProveedorID
            return Convert.ToInt32(cmd.ExecuteScalar());
        }


        /// <summary>
        /// Inserta un nuevo registro de precio de compra.
        /// </summary>
        /// <returns>El nuevo PrecioCompraID</returns>
        public int RegistrarPrecioCompra(
            int medicamentoID,
            int? proveedorID,
            decimal precioUnitario,
            decimal cantidad,
            string comentario = null
        )
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.sp_RegistrarPrecioCompra", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);
            cmd.Parameters.AddWithValue("@ProveedorID", (object)proveedorID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
            cmd.Parameters.AddWithValue("@Cantidad", cantidad);
            cmd.Parameters.AddWithValue("@Comentario", (object)comentario ?? DBNull.Value);

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Recupera el último precio de compra registrado para un medicamento.
        /// </summary>
        public PrecioCompraDTO ObtenerUltimoPrecioCompra(int medicamentoID)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.sp_ObtenerUltimoPrecioCompra", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);

            conn.Open();
            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return null;

            return new PrecioCompraDTO
            {
                PrecioCompraID = rdr.GetInt32(rdr.GetOrdinal("PrecioCompraID")),
                MedicamentoID = rdr.GetInt32(rdr.GetOrdinal("MedicamentoID")),
                ProveedorID = rdr.IsDBNull(rdr.GetOrdinal("ProveedorID"))
                                     ? (int?)null
                                     : rdr.GetInt32(rdr.GetOrdinal("ProveedorID")),
                FechaCompra = rdr.GetDateTime(rdr.GetOrdinal("FechaCompra")),
                PrecioUnitario = rdr.GetDecimal(rdr.GetOrdinal("PrecioUnitario")),
                Cantidad = rdr.GetDecimal(rdr.GetOrdinal("Cantidad")),
                Comentario = rdr.IsDBNull(rdr.GetOrdinal("Comentario"))
                                     ? null
                                     : rdr.GetString(rdr.GetOrdinal("Comentario"))
            };
        }

        // 4.1 Registrar (cierra el anterior y abre el nuevo)
        public int AgregarPrecioMedicamento(int medicamentoID, decimal precio, string comentario = null)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.sp_AgregarPrecioMedicamento", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Comentario",
                (object)comentario ?? DBNull.Value);

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // 4.2 Obtener el precio vigente
        public PrecioMedicamentoDTO ObtenerPrecioMedicamentoActual(int medicamentoID)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.sp_ObtenerPrecioMedicamentoActual", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);
            conn.Open();

            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return null;

            return new PrecioMedicamentoDTO
            {
                PrecioMedicamentoID = rdr.GetInt32(rdr.GetOrdinal("PrecioMedicamentoID")),
                MedicamentoID = rdr.GetInt32(rdr.GetOrdinal("MedicamentoID")),
                Precio = rdr.GetDecimal(rdr.GetOrdinal("Precio")),
                FechaInicio = rdr.GetDateTime(rdr.GetOrdinal("FechaInicio")),
                FechaFin = rdr.IsDBNull(rdr.GetOrdinal("FechaFin"))
                                         ? (DateTime?)null
                                         : rdr.GetDateTime(rdr.GetOrdinal("FechaFin")),
                Comentario = rdr.IsDBNull(rdr.GetOrdinal("Comentario"))
                                         ? null
                                         : rdr.GetString(rdr.GetOrdinal("Comentario"))
            };
        }

        /// <summary>
        /// Actualiza un precio de venta ya existente.
        /// </summary>
        /// <returns>True si se actualizó al menos una fila.</returns>
        public bool ActualizarPrecioMedicamento(int precioMedicamentoID, decimal nuevoPrecio, string comentario = null)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.sp_ActualizarPrecioMedicamento", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@PrecioMedicamentoID", precioMedicamentoID);
            cmd.Parameters.AddWithValue("@Precio", nuevoPrecio);
            cmd.Parameters.AddWithValue("@Comentario", (object)comentario ?? DBNull.Value);

            conn.Open();
            // ExecuteScalar devuelve el @@ROWCOUNT
            int filas = Convert.ToInt32(cmd.ExecuteScalar());
            return filas > 0;
        }


        /// <summary>
        /// Actualiza un precio de compra ya existente.
        /// </summary>
        /// <returns>True si se actualizó al menos una fila.</returns>
        public bool ActualizarPrecioCompra(int precioCompraID, decimal nuevoPrecioUnitario, decimal nuevaCantidad, string comentario = null)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.sp_ActualizarPrecioCompra", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@PrecioCompraID", precioCompraID);
            cmd.Parameters.AddWithValue("@PrecioUnitario", nuevoPrecioUnitario);
            cmd.Parameters.AddWithValue("@Cantidad", nuevaCantidad);
            cmd.Parameters.AddWithValue("@Comentario", (object)comentario ?? DBNull.Value);

            conn.Open();
            int filas = Convert.ToInt32(cmd.ExecuteScalar());
            return filas > 0;
        }

        public List<proveedorDTO> ObtenerProveedoresDTO()
        {
            var lista = new List<proveedorDTO>();
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("dbo.sp_ObtenerProveedoresDTO", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new proveedorDTO
                {
                    ProveedorID = reader.GetInt32(reader.GetOrdinal("ProveedorID")),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                });
            }

            return lista;
        }


    }

}

