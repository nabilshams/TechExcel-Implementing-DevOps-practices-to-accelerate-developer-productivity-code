using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        // testing the CI workflow 3rd time
        // building container image in the workflow.
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(250, ErrorMessage = "There's a 250 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
