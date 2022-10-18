using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;

        Repository<Comment> repoComment = new Repository<Comment>();
        private EfCommentDal efCommentDal;

        public CommentManager(EfCommentDal efCommentDal)
        {
            this.efCommentDal = efCommentDal;
        }

        public List<Comment> commentList()
        {
            // Bu metot sitede yapılan bütün yorumları listeler, admin panelinde kullanılır.
            return repoComment.list();
        }

        public List<Comment> commentByBlog(int id)
        {
            // Bir bloğa yapılan yorumları listeleyen metot budur.
            return _commentDal.list(x => x.blogId == id);
        }

        public List<Comment> commentByStatusTrue()
        {
            // Bir bloğa yapılan yorumlardan durumu true yani yayınlananları listeleyen metot budur.
            return _commentDal.list(x => x.status == true);
        }

        public List<Comment> commentByStatusFalse()
        {
            // Bir bloğa yapılan yorumlardan durumu false yani yayınlanmayanları listeleyen metot budur.
            return repoComment.list(x => x.status == false);
        }

        public void commentStatusChangeToFalse(int id)
        {
            Comment comment = _commentDal.find(x => x.id == id);
            comment.status = false;
            _commentDal.update(comment);
        }

        public void commentStatusChangeToTrue(int id)
        {
            Comment comment = _commentDal.find(x => x.id == id);
            comment.status = true;
            _commentDal.update(comment);
        }

        public List<Comment> getList()
        {
            throw new NotImplementedException();
        }

        public Comment getById(int id)
        {
            throw new NotImplementedException();
        }

        public void updateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void deleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
            _commentDal.insert(t);
        }

        public void updateT(Comment t)
        {
            throw new NotImplementedException();
        }

        public void deleteT(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
