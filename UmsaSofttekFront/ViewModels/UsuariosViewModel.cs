using Data.DTOs;

namespace UmsaSofttekFront.ViewModels
{
    public class UsuariosViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public static implicit operator UsuariosViewModel(UsuarioDto usuario)
        {
            var usuariosViewModel = new UsuariosViewModel();
            usuariosViewModel.Id = usuario.Id;
            usuariosViewModel.FirstName = usuario.FirstName;
            usuariosViewModel.LastName = usuario.LastName;
            usuariosViewModel.Email = usuario.Email;
            usuariosViewModel.Password = usuario.Password;
            usuariosViewModel.RoleId = usuario.RoleId;
            return usuariosViewModel;
        }
    }
}
