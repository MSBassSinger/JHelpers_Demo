using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHelpers_Demo
{

	public class MultiObject
	{

		private IDictionary<String, List<String>> m_NamedList = null;


		public MultiObject()
		{
			m_NamedList = new Dictionary<String, List<String>>();
		}

		public IDictionary<String, List<String>> NamedList
		{
			get
			{
				return m_NamedList;
			}
		}

		public void Clear()
		{
			if (m_NamedList != null)
			{
				m_NamedList.Clear();

				m_NamedList = null;
			}
		}

	}
}
