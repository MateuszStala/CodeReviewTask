using System;
using System.Diagnostics;

public class Delete
{
	public Delete()
	{
        [HttpPost("delete/{id}")]
        public void Delete(uint id)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            Debug.WriteLine($"The user with Login={user.login} has been deleted");
            return Ok();
        }
    }
}
