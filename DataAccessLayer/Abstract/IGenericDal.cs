using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        //Igenericdal dedik topkı diğer dal  lrdaki gibi metodların imzalarını yazdık parametre olarak T verdik
        //ve T ye kural koyduk
        // insert,update,delete standart oldu
        //getbyid ve listall ise azıcık değişti
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetListAll();//T türünden getlistall
        T GetById(int id);//T türünden get by id ve 

    }
}
