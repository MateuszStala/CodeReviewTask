using System;
using System.Diagnostics;

public class DeleteUserById
{
	public DeleteUserById()
	{
        [HttpDelete("deleteUserById/{id}")]
        public IActionResult DeleteUserById(uint id)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == id);

            if(user == null) { 
                return NotFound($"The user with id = {id} hasnt been found");
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            Debug.WriteLine($"The user with Login = {user.Login} has been deleted");
            return Ok();
        }
    }
}
