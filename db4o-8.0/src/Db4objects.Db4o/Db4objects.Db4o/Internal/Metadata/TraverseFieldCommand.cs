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
using Db4objects.Db4o.Internal;
using Db4objects.Db4o.Internal.Metadata;

namespace Db4objects.Db4o.Internal.Metadata
{
	/// <exclude></exclude>
	public abstract class TraverseFieldCommand : ITraverseAspectCommand
	{
		public virtual bool Cancelled()
		{
			return false;
		}

		public virtual int DeclaredAspectCount(ClassMetadata classMetadata)
		{
			return classMetadata.DeclaredAspectCount();
		}

		public virtual void ProcessAspect(ClassAspect aspect, int currentSlot)
		{
			if (aspect is FieldMetadata)
			{
				Process((FieldMetadata)aspect);
			}
		}

		public virtual void ProcessAspectOnMissingClass(ClassAspect aspect, int currentSlot
			)
		{
		}

		// do nothing
		protected abstract void Process(FieldMetadata field);
	}
}
