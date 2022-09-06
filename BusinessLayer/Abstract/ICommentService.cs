using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        List<Comment> getList();
        void commentAdd(Comment comment);
        Comment getById(int id);
        void updateComment(Comment comment);
        void deleteComment(Comment comment);
    }
}
