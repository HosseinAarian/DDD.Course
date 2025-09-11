
namespace DDD.Domain.ValueObjects
{
	[Serializable]
	internal class InvalidDescriptionLenght : Exception
	{
		public InvalidDescriptionLenght()
		{
		}

		public InvalidDescriptionLenght(string? message) : base(message)
		{
		}

		public InvalidDescriptionLenght(string? message, Exception? innerException) : base(message, innerException)
		{
		}
	}
}