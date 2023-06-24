using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public struct FixedBitArray3 : IEnumerable, IEnumerable<bool>
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x28AFDF0", Offset = "0x28AE3F0", VA = "0x1828AFDF0", Slot = "4")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700002B RID: 43
		[Token(Token = "0x1700002B")]
		public bool this[int index]
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x28AFE00", Offset = "0x28AE400", VA = "0x1828AFE00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x28AFE70", Offset = "0x28AE470", VA = "0x1828AFE70")]
			set
			{
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x28AFEE0", Offset = "0x28AE4E0", VA = "0x1828AFEE0")]
		public bool Contains(bool value)
		{
			return default(bool);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x28AFF40", Offset = "0x28AE540", VA = "0x1828AFF40")]
		public int IndexOf(bool value)
		{
			return 0;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x28AFFA0", Offset = "0x28AE5A0", VA = "0x1828AFFA0")]
		public void Clear()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x28AFFB0", Offset = "0x28AE5B0", VA = "0x1828AFFB0")]
		public void Clear(bool value)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x28B0050", Offset = "0x28AE650", VA = "0x1828B0050")]
		[DebuggerHidden]
		private IEnumerable<bool> Enumerate()
		{
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x28B00B0", Offset = "0x28AE6B0", VA = "0x1828B00B0", Slot = "5")]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x0")]
		public bool _0;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x1")]
		public bool _1;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x2")]
		public bool _2;
	}
}
