using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
       
        public void AddBlog(Blog blog)
        {
            using var c=new Context();
            c.Add(blog);//add metodu entityframeworkcore içinde gelen  metod
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetBlog(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id); // burda contextteki ambar gibi olan blogs içinde ilgili idye göre bulacaksın
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();//contextteki blogs un tamamını listeleyecegim için içine parametre vermeye gerek yook
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new Context();
            c.Blogs.Update(blog);
            c.SaveChanges();
        }
    }
}
