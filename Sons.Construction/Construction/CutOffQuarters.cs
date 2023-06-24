using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	[AddComponentMenu("Sons/Construction/CutOffQuarters")]
	public class CutOffQuarters : CutLogBase
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x000050E4 File Offset: 0x000032E4
		[Token(Token = "0x17000237")]
		public SnappingUtils.Axis ForwardAxis
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return SnappingUtils.Axis.X;
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CutOffQuarters()
		{
		}

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SnappingUtils.Axis _forwardAxis;
	}
}
