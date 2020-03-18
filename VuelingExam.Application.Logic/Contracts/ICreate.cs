namespace VuelingExam.Application.Logic.Contracts
{
	public interface ICreate<T>
	{
		bool Create(T model);
	}
}
