
using System.ComponentModel.DataAnnotations.Schema;

namespace DG.API.ENTITY
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}