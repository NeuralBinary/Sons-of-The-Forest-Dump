using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000805 RID: 2053
	[Token(Token = "0x2000805")]
	public class ReviveVailActor : MonoBehaviour
	{
		// Token: 0x06003759 RID: 14169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x353DB80", Offset = "0x353C180", VA = "0x18353DB80")]
		private void OnValidate()
		{
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x21BE7E0", Offset = "0x21BCDE0", VA = "0x1821BE7E0")]
		private void GrabEnter()
		{
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x737F70", Offset = "0x736570", VA = "0x180737F70")]
		private void GrabExit()
		{
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x353DCB0", Offset = "0x353C2B0", VA = "0x18353DCB0")]
		private void Update()
		{
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x353DE30", Offset = "0x353C430", VA = "0x18353DE30")]
		private void OnDisable()
		{
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x353DE40", Offset = "0x353C440", VA = "0x18353DE40")]
		private void SetReviveEnabled(bool value)
		{
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x353DF10", Offset = "0x353C510", VA = "0x18353DF10")]
		private void Revive()
		{
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x353E170", Offset = "0x353C770", VA = "0x18353E170")]
		private void ClientSendReviveEvent()
		{
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003761")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ReviveVailActor()
		{
		}

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x04002FCB RID: 12235
		[Token(Token = "0x4002FCB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _reviveUI;

		// Token: 0x04002FCC RID: 12236
		[Token(Token = "0x4002FCC")]
		[FieldOffset(Offset = "0x30")]
		private bool _grabEnabled;
	}
}
