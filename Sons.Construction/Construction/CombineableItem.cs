using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	[AddComponentMenu("Sons/Construction/CombineableItem")]
	public class CombineableItem : MonoBehaviour, IElementIdentifier
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000233")]
		public ElementProfile Profile
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x17000234")]
		public SnappingUtils.Axis ForwardAxis
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return SnappingUtils.Axis.X;
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CombineableItem()
		{
		}

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ElementProfile _profile;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SnappingUtils.Axis _forwardAxis;
	}
}
