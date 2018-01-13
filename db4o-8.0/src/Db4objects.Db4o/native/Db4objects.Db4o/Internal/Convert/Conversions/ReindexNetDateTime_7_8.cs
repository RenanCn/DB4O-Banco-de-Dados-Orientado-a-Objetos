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
using System;

namespace Db4objects.Db4o.Internal.Convert.Conversions
{
    partial class ReindexNetDateTime_7_8 : Conversion
    {
		public override void Convert(ConversionStage.SystemUpStage stage)
		{
			ReindexDateTimeFields(stage);
		}

		private static void ReindexDateTimeFields(ConversionStage stage)
		{
			FieldReindexer<DateTime> reindexer = new FieldReindexer<DateTime>();
			
			ClassMetadataIterator i = stage.File().ClassCollection().Iterator();
			while (i.MoveNext())
			{
				ClassMetadata classmetadata = i.CurrentClass();
				classmetadata.TraverseDeclaredFields(reindexer);
			}
		}
    }
}
