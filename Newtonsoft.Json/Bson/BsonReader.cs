using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonReader : JsonReader
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00007110 File Offset: 0x00005310
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AD")]
		[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		public bool JsonNet35BinaryCompatibility
		{
			[Token(Token = "0x6000FDB")]
			[Address(RVA = "0x26093C0", Offset = "0x26079C0", VA = "0x1826093C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FDC")]
			[Address(RVA = "0x26093D0", Offset = "0x26079D0", VA = "0x1826093D0")]
			set
			{
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00007128 File Offset: 0x00005328
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		public bool ReadRootValueAsArray
		{
			[Token(Token = "0x6000FDD")]
			[Address(RVA = "0x26093E0", Offset = "0x26079E0", VA = "0x1826093E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FDE")]
			[Address(RVA = "0x784C10", Offset = "0x783210", VA = "0x180784C10")]
			set
			{
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00007140 File Offset: 0x00005340
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AF")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x6000FDF")]
			[Address(RVA = "0x7283B0", Offset = "0x7269B0", VA = "0x1807283B0")]
			get
			{
				return DateTimeKind.Unspecified;
			}
			[Token(Token = "0x6000FE0")]
			[Address(RVA = "0x7283C0", Offset = "0x7269C0", VA = "0x1807283C0")]
			set
			{
			}
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x26093F0", Offset = "0x26079F0", VA = "0x1826093F0")]
		public BsonReader(Stream stream)
		{
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x2609410", Offset = "0x2607A10", VA = "0x182609410")]
		public BsonReader(BinaryReader reader)
		{
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x26095E0", Offset = "0x2607BE0", VA = "0x1826095E0")]
		public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x26097F0", Offset = "0x2607DF0", VA = "0x1826097F0")]
		public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x26099D0", Offset = "0x2607FD0", VA = "0x1826099D0")]
		private string ReadElement()
		{
			return null;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x2609A20", Offset = "0x2608020", VA = "0x182609A20", Slot = "21")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x2609C30", Offset = "0x2608230", VA = "0x182609C30", Slot = "31")]
		public override void Close()
		{
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x2609CC0", Offset = "0x26082C0", VA = "0x182609CC0")]
		private bool ReadCodeWScope()
		{
			return default(bool);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x260A210", Offset = "0x2608810", VA = "0x18260A210")]
		private bool ReadReference()
		{
			return default(bool);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x260A860", Offset = "0x2608E60", VA = "0x18260A860")]
		private bool ReadNormal()
		{
			return default(bool);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x260ABA0", Offset = "0x26091A0", VA = "0x18260ABA0")]
		private void PopContext()
		{
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x260AD30", Offset = "0x2609330", VA = "0x18260AD30")]
		private void PushContext(BsonReader.ContainerContext newContext)
		{
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x260AE20", Offset = "0x2609420", VA = "0x18260AE20")]
		private byte ReadByte()
		{
			return 0;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x260AE60", Offset = "0x2609460", VA = "0x18260AE60")]
		private void ReadType(BsonType type)
		{
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x260B960", Offset = "0x2609F60", VA = "0x18260B960")]
		private byte[] ReadBinary(out BsonBinaryType binaryType)
		{
			return null;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x260BA60", Offset = "0x260A060", VA = "0x18260BA60")]
		private string ReadString()
		{
			return null;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x260BDD0", Offset = "0x260A3D0", VA = "0x18260BDD0")]
		private string ReadLengthString()
		{
			return null;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x260BE60", Offset = "0x260A460", VA = "0x18260BE60")]
		private string GetString(int length)
		{
			return null;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x260C190", Offset = "0x260A790", VA = "0x18260C190")]
		private int GetLastFullCharStop(int start)
		{
			return 0;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x260C220", Offset = "0x260A820", VA = "0x18260C220")]
		private int BytesInSequence(byte b)
		{
			return 0;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x260C410", Offset = "0x260AA10", VA = "0x18260C410")]
		private void EnsureBuffers()
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x260C560", Offset = "0x260AB60", VA = "0x18260C560")]
		private double ReadDouble()
		{
			return 0.0;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00007218 File Offset: 0x00005418
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x260C5A0", Offset = "0x260ABA0", VA = "0x18260C5A0")]
		private int ReadInt32()
		{
			return 0;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x260C5E0", Offset = "0x260ABE0", VA = "0x18260C5E0")]
		private long ReadInt64()
		{
			return 0L;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00007248 File Offset: 0x00005448
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x260C620", Offset = "0x260AC20", VA = "0x18260C620")]
		private BsonType ReadType()
		{
			return (BsonType)0;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x260C660", Offset = "0x260AC60", VA = "0x18260C660")]
		private void MovePosition(int count)
		{
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x260C680", Offset = "0x260AC80", VA = "0x18260C680")]
		private byte[] ReadBytes(int count)
		{
			return null;
		}

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		private const int MaxCharBytesSize = 128;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] SeqRange1;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] SeqRange2;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] SeqRange3;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] SeqRange4;

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x78")]
		private readonly BinaryReader _reader;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<BsonReader.ContainerContext> _stack;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x88")]
		private byte[] _byteBuffer;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x90")]
		private char[] _charBuffer;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x98")]
		private BsonType _currentElementType;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x9C")]
		private BsonReader.BsonReaderState _bsonReaderState;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0xA0")]
		private BsonReader.ContainerContext _currentContext;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0xA8")]
		private bool _readRootValueAsArray;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0xA9")]
		private bool _jsonNet35BinaryCompatibility;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0xAC")]
		private DateTimeKind _dateTimeKindHandling;

		// Token: 0x020001D8 RID: 472
		[Token(Token = "0x20001D8")]
		private enum BsonReaderState
		{
			// Token: 0x04000846 RID: 2118
			[Token(Token = "0x4000846")]
			Normal,
			// Token: 0x04000847 RID: 2119
			[Token(Token = "0x4000847")]
			ReferenceStart,
			// Token: 0x04000848 RID: 2120
			[Token(Token = "0x4000848")]
			ReferenceRef,
			// Token: 0x04000849 RID: 2121
			[Token(Token = "0x4000849")]
			ReferenceId,
			// Token: 0x0400084A RID: 2122
			[Token(Token = "0x400084A")]
			CodeWScopeStart,
			// Token: 0x0400084B RID: 2123
			[Token(Token = "0x400084B")]
			CodeWScopeCode,
			// Token: 0x0400084C RID: 2124
			[Token(Token = "0x400084C")]
			CodeWScopeScope,
			// Token: 0x0400084D RID: 2125
			[Token(Token = "0x400084D")]
			CodeWScopeScopeObject,
			// Token: 0x0400084E RID: 2126
			[Token(Token = "0x400084E")]
			CodeWScopeScopeEnd
		}

		// Token: 0x020001D9 RID: 473
		[Token(Token = "0x20001D9")]
		private class ContainerContext
		{
			// Token: 0x06000FFD RID: 4093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FFD")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			public ContainerContext(BsonType type)
			{
			}

			// Token: 0x0400084F RID: 2127
			[Token(Token = "0x400084F")]
			[FieldOffset(Offset = "0x10")]
			public readonly BsonType Type;

			// Token: 0x04000850 RID: 2128
			[Token(Token = "0x4000850")]
			[FieldOffset(Offset = "0x14")]
			public int Length;

			// Token: 0x04000851 RID: 2129
			[Token(Token = "0x4000851")]
			[FieldOffset(Offset = "0x18")]
			public int Position;
		}
	}
}
