using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200034F RID: 847
	[Token(Token = "0x200034F")]
	public class Bitmap2
	{
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x00013D3C File Offset: 0x00011F3C
		[Token(Token = "0x1700042B")]
		public Vector2i Dimensions
		{
			[Token(Token = "0x6001BEA")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return default(Vector2i);
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x1F65F90", Offset = "0x1F64590", VA = "0x181F65F90")]
		public Bitmap2(Vector2i dims)
		{
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x1F65FA0", Offset = "0x1F645A0", VA = "0x181F65FA0")]
		public Bitmap2(int Width, int Height)
		{
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x1F65FC0", Offset = "0x1F645C0", VA = "0x181F65FC0")]
		public void Resize(Vector2i dims)
		{
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00013D54 File Offset: 0x00011F54
		[Token(Token = "0x1700042C")]
		public AxisAlignedBox2i GridBounds
		{
			[Token(Token = "0x6001BEE")]
			[Address(RVA = "0x1F66080", Offset = "0x1F64680", VA = "0x181F66080")]
			get
			{
				return default(AxisAlignedBox2i);
			}
		}

		// Token: 0x1700042D RID: 1069
		[Token(Token = "0x1700042D")]
		public bool this[int i]
		{
			[Token(Token = "0x6001BEF")]
			[Address(RVA = "0x1F66100", Offset = "0x1F64700", VA = "0x181F66100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0x1F66120", Offset = "0x1F64720", VA = "0x181F66120")]
			set
			{
			}
		}

		// Token: 0x1700042E RID: 1070
		[Token(Token = "0x1700042E")]
		public bool this[int r, int c]
		{
			[Token(Token = "0x6001BF1")]
			[Address(RVA = "0x1F66140", Offset = "0x1F64740", VA = "0x181F66140")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0x1F66170", Offset = "0x1F64770", VA = "0x181F66170")]
			set
			{
			}
		}

		// Token: 0x1700042F RID: 1071
		[Token(Token = "0x1700042F")]
		public bool this[Vector2i idx]
		{
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0x1F661B0", Offset = "0x1F647B0", VA = "0x181F661B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0x1F661E0", Offset = "0x1F647E0", VA = "0x181F661E0")]
			set
			{
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x1F661E0", Offset = "0x1F647E0", VA = "0x181F661E0")]
		public void Set(Vector2i idx, bool val)
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00013DB4 File Offset: 0x00011FB4
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x1F661B0", Offset = "0x1F647B0", VA = "0x181F661B0")]
		public bool Get(Vector2i idx)
		{
			return default(bool);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00013DCC File Offset: 0x00011FCC
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x1F66210", Offset = "0x1F64810", VA = "0x181F66210")]
		public Vector2i ToIndex(int i)
		{
			return default(Vector2i);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00013DE4 File Offset: 0x00011FE4
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x1F66240", Offset = "0x1F64840", VA = "0x181F66240")]
		public int ToLinear(Vector2i idx)
		{
			return 0;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x1F66250", Offset = "0x1F64850", VA = "0x181F66250")]
		public IEnumerable<Vector2i> Indices()
		{
			return null;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x1F662F0", Offset = "0x1F648F0", VA = "0x181F662F0")]
		public IEnumerable<Vector2i> NonZeros()
		{
			return null;
		}

		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x10")]
		public BitArray Bits;

		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x18")]
		private Vector2i dimensions;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x20")]
		private int row_size;
	}
}
