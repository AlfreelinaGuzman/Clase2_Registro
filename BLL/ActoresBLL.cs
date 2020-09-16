using System;
using System.Windows;
using System.Linq;
using System.Linq.Expressions;
using Pruebas.DAL;
using System.Collections.Generic;
using Pruebas.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Pruebas.BLL
{
    public class ActoresBLL
    {
    public static bool Guardar (Actores actores){
            bool Guardado;
            Contexto contexto= new Contexto();

            try
            {
                contexto.Actores.Add(actores);
                Guardado=contexto.SaveChanges()>0;

            }catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }
          return Guardado;
        }

    public  static Actores Buscar(int id){
        Contexto contexto=new Contexto();
        Actores actores;
        try{
            actores= contexto.Actores.Find(id);
        }
        catch (Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }
          return actores;
        }
    }

    }