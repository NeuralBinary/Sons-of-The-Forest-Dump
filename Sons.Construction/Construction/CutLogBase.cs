using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	public abstract class CutLogBase : MonoBehaviour
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000235")]
		public ElementProfile Profile
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x000050CC File Offset: 0x000032CC
		[Token(Token = "0x17000236")]
		public Vector3 Forward
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x2E37E40", Offset = "0x2E36440", VA = "0x182E37E40")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x2E37ED0", Offset = "0x2E364D0", VA = "0x182E37ED0")]
		public void SlowDown()
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected CutLogBase()
		{
		}

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ElementProfile _profile;
	}
}
