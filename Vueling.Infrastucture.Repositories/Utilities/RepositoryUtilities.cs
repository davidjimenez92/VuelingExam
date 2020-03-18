using System;
using System.IO;
using VuelingExam.Domain.Entities;

namespace Vueling.Infrastucture.Repositories.Utilities
{
	class RepositoryUtilities
	{
		private readonly string path = null;

		public RepositoryUtilities(string path)
		{
			this.path = path;
		}

		/// <exception cref="UnauthorizedAccessException"></exception>>
		/// <exception cref="PathTooLongException"></exception>>
		/// <exception cref="DirectoryNotFoundException"></exception>>
		/// <exception cref="IOException"></exception>>
		public void CreateFile()
		{
			if (!FileExists())
				try
				{
					File.Create(path);
				}
				catch (UnauthorizedAccessException ex)
				{
					throw ex;
				}
				catch (PathTooLongException ex)
				{
					throw ex;
				}
				catch (DirectoryNotFoundException ex)
				{
					throw ex;
				}
				catch (IOException ex)
				{
					throw ex;
				}
				
		}

		public bool FileExists()
		{
			return File.Exists(path);
		}

		public bool AppendRegister(Register model)
		{
			using (StreamWriter streamWriter = File.AppendText(path))
			{
				streamWriter.WriteLine(model.ToString());
				return true;
			}
		}
	}
}
