using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Utilities
{
	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x200057E")]
	[AddComponentMenu("Sons/Multiplayer/Utilities/RemoveComponentOnClient")]
	public class RemoveComponentOnClient : MonoBehaviour
	{
		// Token: 0x0600251F RID: 9503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x3398330", Offset = "0x3396930", VA = "0x183398330")]
		private void Awake()
		{
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x33983F0", Offset = "0x33969F0", VA = "0x1833983F0")]
		private void Start()
		{
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002521")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RemoveComponentOnClient()
		{
		}

		// Token: 0x0400214D RID: 8525
		[Token(Token = "0x400214D")]
		[FieldOffset(Offset = "0x20")]
		public bool _awake;

		// Token: 0x0400214E RID: 8526
		[Token(Token = "0x400214E")]
		[FieldOffset(Offset = "0x21")]
		public bool _start;

		// Token: 0x0400214F RID: 8527
		[Token(Token = "0x400214F")]
		[FieldOffset(Offset = "0x28")]
		public Component _targetComponent;
	}
}
