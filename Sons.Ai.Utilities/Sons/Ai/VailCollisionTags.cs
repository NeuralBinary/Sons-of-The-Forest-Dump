using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class VailCollisionTags : MonoBehaviour
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x17000005")]
		public bool Jumpable
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x17000006")]
		public bool CanStandOn
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x17000007")]
		public bool UseLocalAvoid
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x993970", Offset = "0x991F70", VA = "0x180993970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x17000008")]
		public bool DisableVisionBlock
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2A99E50", Offset = "0x2A98450", VA = "0x182A99E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VailCollisionTags()
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Actor will not try to auto-jump over this object")]
		[SerializeField]
		private bool _jumpable;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		[Tooltip("Spawn trace will go through this object and turns off step-up smoothing on it")]
		private bool _canStandOn;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		[Tooltip("Shouldn't need local avoid if there are navmesh cuts. Local avoid currently made for things like trees that can be easily avoiding moving a point a bit to any side.")]
		private bool _useLocalAvoid;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		[Tooltip("Actor vision check trace will go through this object")]
		private bool _disableVisionBlock;
	}
}
