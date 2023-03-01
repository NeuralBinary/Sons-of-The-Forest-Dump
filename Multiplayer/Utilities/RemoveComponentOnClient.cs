using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Utilities
{
	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200056E")]
	[AddComponentMenu("Sons/Multiplayer/Utilities/RemoveComponentOnClient")]
	public class RemoveComponentOnClient : MonoBehaviour
	{
		// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x2D8BC80", Offset = "0x2D8AC80", VA = "0x182D8BC80")]
		private void Awake()
		{
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x2D8BD10", Offset = "0x2D8AD10", VA = "0x182D8BD10")]
		private void Start()
		{
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public RemoveComponentOnClient()
		{
		}

		// Token: 0x04002079 RID: 8313
		[Token(Token = "0x4002079")]
		[FieldOffset(Offset = "0x20")]
		public bool _awake;

		// Token: 0x0400207A RID: 8314
		[Token(Token = "0x400207A")]
		[FieldOffset(Offset = "0x21")]
		public bool _start;

		// Token: 0x0400207B RID: 8315
		[Token(Token = "0x400207B")]
		[FieldOffset(Offset = "0x28")]
		public Component _targetComponent;
	}
}
