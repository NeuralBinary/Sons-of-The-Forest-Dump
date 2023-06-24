using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Construction
{
	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	[AddComponentMenu("Sons/Construction/TarpCornerAttachements")]
	public class TarpCornerAttachments : MonoBehaviour
	{
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003F8")]
		public Transform[] CornerAttachments
		{
			[Token(Token = "0x600114A")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x2F22730", Offset = "0x2F20D30", VA = "0x182F22730")]
		public void SetCornerPos(TarpDirections tarpDir, Vector3 worldPos)
		{
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TarpCornerAttachments()
		{
		}

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_cornerAttachements")]
		private Transform[] _cornerAttachments;
	}
}
