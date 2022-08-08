using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repoComment = new Repository<Comment>();

        public List<Comment> commentList()
        {
            // Bu metot sitede yapılan bütün yorumları listeler, admin panelinde kullanılır.
            return repoComment.list();  
        }

        public List<Comment> commentByBlog(int id)
        {
            // Bir bloğa yapılan yorumları listeleyen metot budur.
            return repoComment.list(x=>x.blogId==id);
        }

        public int commentAdd(Comment c)
        {
            // Bir bloğa yorum ekleme metodu
            if(c.text.Length<=4 || c.text.Length>=401 || c.userName=="" || c.mail == "")
            {
                return -1;
            }
            return repoComment.insert(c);
        }
    }
}
