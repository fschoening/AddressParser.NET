﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressParser.Model.AddressTypes;

namespace AddressParser.Model.Interfaces
{
	public interface ITestDataLoader
	{
		List<TestAddress> GetTestAddresses(string filename);
	}
}