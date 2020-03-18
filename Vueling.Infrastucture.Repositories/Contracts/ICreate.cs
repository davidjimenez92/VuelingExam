namespace Vueling.Infrastucture.Repositories.Contracts
{
	public interface ICreate<T>
	{
		bool Create(T model);
	}
}
