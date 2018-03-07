using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CRUD2017.EF;
using System.Web.Mvc;
using CRUD2017.Models;

namespace CRUD2017.Controllers
{
    public class ConhecimentoController : Controller
    {    
        public JsonResult GetAllProgram()
        {
            using (Banco bco = new Banco())
            {
                try
                {
                    var progrs = (from p in bco.Programadores
                                  join c in bco.Conhecimentos on p.cod_prog_id equals c.cod_prog_id
                                  join db in bco.DBancarios on p.cod_prog_id equals db.cod_prog_id
                                  join edn in bco.Enderecos on p.cod_prog_id equals edn.cod_prog_id
                                  select new
                                  {
                                      p.cod_prog_id,
                                      p.nome_prog,
                                      p.skype_prog,
                                      p.celular,
                                      p.linkedin,
                                      p.portifolio,
                                      p.disp_horas,
                                      p.melhor_hora,
                                      p.pretensao_hora,
                                      c.Android,
                                      c.AngularJs,
                                      c.AspNetMVC,
                                      c.Bootstrap,
                                      c.Cake,
                                      c.CSS,
                                      c.C_mais_mais,
                                      c.Django,
                                      c.Ionic,
                                      c.IOS,
                                      c.Jquery,
                                      c.Java,
                                      c.PHP,
                                      c.Wordpress,
                                      c.Phyton,
                                      c.MySQLServer,
                                      c.Ruby,
                                      c.MySQL,
                                      c.Salesforce,
                                      c.Photoshop,
                                      c.Illustrator,
                                      c.SEO,
                                      c.Majento,
                                      c.HTML,
                                      db.nome_Favorecido,
                                      db.nro_agencia,
                                      db.nro_conta,
                                      db.n_cpf,
                                      db.tp_conta,
                                      edn.cep,
                                      edn.logradouro,
                                      edn.nro_residencia,
                                      edn.bairro,
                                      edn.cidade,
                                      edn.estado
                                  }).ToList();

                    return Json(progrs, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public JsonResult GetById(int id)
        {
            using (Banco bco = new Banco())
            {
                try
                {
                    var pcbe = (from p in bco.Programadores
                                join c in bco.Conhecimentos on p.cod_prog_id equals c.cod_prog_id
                                join db in bco.DBancarios on p.cod_prog_id equals db.cod_prog_id
                                join end in bco.Enderecos on p.cod_prog_id equals end.cod_prog_id
                                where
                                    p.cod_prog_id == id || c.cod_prog_id == id ||
                                    db.cod_prog_id == id || end.cod_prog_id == id
                                select new
                                {
                                    p.cod_prog_id,
                                    p.nome_prog,
                                    p.skype_prog,
                                    p.celular,
                                    p.linkedin,
                                    p.portifolio,
                                    p.disp_horas,
                                    p.melhor_hora,
                                    p.pretensao_hora,
                                    c.Android,
                                    c.AngularJs,
                                    c.AspNetMVC,
                                    c.Bootstrap,
                                    c.Cake,
                                    c.CSS,
                                    c.C_mais_mais,
                                    c.Django,
                                    c.Ionic,
                                    c.IOS,
                                    c.Jquery,
                                    c.Java,
                                    c.PHP,
                                    c.Wordpress,
                                    c.Phyton,
                                    c.MySQLServer,
                                    c.Ruby,
                                    c.MySQL,
                                    c.Salesforce,
                                    c.Photoshop,
                                    c.Illustrator,
                                    c.SEO,
                                    c.Majento,
                                    c.HTML,
                                    db.nome_Favorecido,
                                    db.nro_agencia,
                                    db.nro_conta,
                                    db.n_cpf,
                                    db.tp_conta,
                                    end.cep,
                                    end.logradouro,
                                    end.nro_residencia,
                                    end.bairro,
                                    end.cidade,
                                    end.estado
                                }).First();
                    return Json(new { pcbe = pcbe }, JsonRequestBehavior.AllowGet);

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public string DelProg(int prog)
        {
            try
            {
                using (Banco bco = new Banco())
                {
                    Programador progr = bco.Programadores.Find(prog);
                    Conhecimento con = bco.Conhecimentos.Find(prog);
                    Endereco end = bco.Enderecos.Find(prog);
                    DBancario dban = bco.DBancarios.Find(prog);

                    bco.Programadores.Remove(progr);
                    bco.Conhecimentos.Remove(con);
                    bco.Enderecos.Remove(end);
                    bco.DBancarios.Remove(dban);

                    bco.SaveChanges();

                    return "Ok";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string AddProg(Programador programers, Conhecimento conhec, DBancario dban, Endereco end)
        {
            if (programers != null && conhec != null && dban != null && end != null)
            {
                using (Banco bco = new Banco())
                {
                    try
                    {
                        bco.Enderecos.Add(end);
                        bco.DBancarios.Add(dban);
                        bco.Conhecimentos.Add(conhec);
                        bco.Programadores.Add(programers);
                        bco.SaveChanges();

                        return "Ok";
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            else
            {
                return "Invalid";
            }
        }     

        public string UpdateProg(Programador prg, Conhecimento con, DBancario db, Endereco en)
        {
            if(prg != null && con != null && db != null && en != null)
            {
                using (Banco bco = new Banco())
                {
                    try
                    {
                        int idp = Convert.ToInt32(prg.cod_prog_id);
                        int idc = Convert.ToInt32(con.cod_prog_id);
                        int idb = Convert.ToInt32(db.cod_prog_id);
                        int ide = Convert.ToInt32(en.cod_prog_id);

                        Programador _prg = bco.Programadores.Find(idp);
                        Conhecimento _con = bco.Conhecimentos.Find(idc);
                        DBancario _db = bco.DBancarios.Find(idb);
                        Endereco _en = bco.Enderecos.Find(ide);

                        _prg.nome_prog = prg.nome_prog;
                        _prg.skype_prog = prg.skype_prog;
                        _prg.celular = prg.celular;
                        _prg.linkedin = prg.linkedin;
                        _prg.portifolio = prg.portifolio;
                        _prg.disp_horas = prg.disp_horas;
                        _prg.melhor_hora = prg.melhor_hora;
                        _prg.pretensao_hora = prg.pretensao_hora;

                        _con.Android = con.Android;
                        _con.AngularJs = con.AngularJs;
                        _con.AspNetMVC = con.AspNetMVC;
                        _con.Bootstrap = con.Bootstrap;
                        _con.Cake = con.Cake;
                        _con.CSS = con.CSS;
                        _con.C_mais_mais = con.C_mais_mais;
                        _con.Django = con.Django;
                        _con.Ionic = con.Ionic;
                        _con.IOS = con.IOS;
                        _con.Jquery = con.Jquery;
                        _con.Java = con.Java;
                        _con.PHP = con.PHP;
                        _con.Wordpress = con.Wordpress;
                        _con.Phyton = con.Phyton;
                        _con.MySQLServer = con.MySQLServer;
                        _con.Ruby = con.Ruby;
                        _con.MySQL = con.MySQL;
                        _con.Salesforce = con.Salesforce;
                        _con.Photoshop = con.Photoshop;
                        _con.Illustrator = con.Illustrator;
                        _con.SEO = con.SEO;
                        _con.Majento = con.Majento;
                        _con.HTML = con.HTML;

                        _db.nome_Favorecido = db.nome_Favorecido;
                        _db.nro_agencia = db.nro_agencia;
                        _db.nro_agencia = db.nro_conta;
                        _db.n_cpf = db.n_cpf;
                        _db.tp_conta = db.tp_conta;

                        _en.cep = en.cep;
                        _en.logradouro = en.logradouro;
                        _en.nro_residencia = en.nro_residencia;
                        _en.bairro = en.bairro;
                        _en.cidade = en.cidade;
                        _en.estado = en.estado;

                        bco.Entry(_prg).State = System.Data.Entity.EntityState.Modified;
                        bco.Entry(_con).State = System.Data.Entity.EntityState.Modified;
                        bco.Entry(_db).State = System.Data.Entity.EntityState.Modified;
                        bco.Entry(_en).State = System.Data.Entity.EntityState.Modified;

                        bco.SaveChanges();                       
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }
                return "Teste";
            }            
            else
            {
                return "Invalid";
            }            
        }
    }
}