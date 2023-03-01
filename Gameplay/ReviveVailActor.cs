using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006CD RID: 1741
	[Token(Token = "0x20006CD")]
	public class ReviveVailActor : MonoBehaviour
	{
		// Token: 0x06002C87 RID: 11399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C87")]
		[Address(RVA = "0x2DE58B0", Offset = "0x2DE48B0", VA = "0x182DE58B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C88")]
		[Address(RVA = "0x229B280", Offset = "0x229A280", VA = "0x18229B280")]
		private void GrabEnter()
		{
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C89")]
		[Address(RVA = "0x6890E0", Offset = "0x6880E0", VA = "0x1806890E0")]
		private void GrabExit()
		{
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0x2DE5B30", Offset = "0x2DE4B30", VA = "0x182DE5B30")]
		private void Update()
		{
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x2DE5860", Offset = "0x2DE4860", VA = "0x182DE5860")]
		private void OnDisable()
		{
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x2DE5AE0", Offset = "0x2DE4AE0", VA = "0x182DE5AE0")]
		private void SetReviveEnabled(bool value)
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x2DE5950", Offset = "0x2DE4950", VA = "0x182DE5950")]
		private void Revive()
		{
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x2DE5790", Offset = "0x2DE4790", VA = "0x182DE5790")]
		private void ClientSendReviveEvent()
		{
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ReviveVailActor()
		{
		}

		// Token: 0x040027DB RID: 10203
		[Token(Token = "0x40027DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x040027DC RID: 10204
		[Token(Token = "0x40027DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _reviveUI;

		// Token: 0x040027DD RID: 10205
		[Token(Token = "0x40027DD")]
		[FieldOffset(Offset = "0x30")]
		private bool _grabEnabled;
	}
}
