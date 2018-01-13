/* This file is part of the db4o object database http://www.db4o.com

Copyright (C) 2004 - 2011  Versant Corporation http://www.versant.com

db4o is free software; you can redistribute it and/or modify it under
the terms of version 3 of the GNU General Public License as published
by the Free Software Foundation.

db4o is distributed in the hope that it will be useful, but WITHOUT ANY
WARRANTY; without even the implied warranty of MERCHANTABILITY or
FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
for more details.

You should have received a copy of the GNU General Public License along
with this program.  If not, see http://www.gnu.org/licenses/. */
using Mono.Cecil;

namespace Db4oTool.Core
{
	public class ByAttributeFilter : ITypeFilter
	{
		public static bool ContainsCustomAttribute(TypeDefinition typeDef, string attributeType)
		{
			foreach (CustomAttribute attribute in typeDef.CustomAttributes)
			{
				if (attributeType == attribute.Constructor.DeclaringType.FullName)
				{
					return true;
				}
			}
			return false;
		}

		private string _attribute;

		public ByAttributeFilter(string attribute)
		{
			_attribute = attribute;
		}

		public bool Accept(TypeDefinition typeDef)
		{
			return ContainsCustomAttribute(typeDef, _attribute);
		}
	}
}
