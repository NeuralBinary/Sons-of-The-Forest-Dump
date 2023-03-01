using System;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.World
{
	// Token: 0x020004EA RID: 1258
	[Token(Token = "0x20004EA")]
	[AddComponentMenu("Sons/Word/Directional Trigger (Unity event)")]
	public class UnityEventDirectionalTrigger : MonoBehaviour
	{
		// Token: 0x0600204B RID: 8267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x2D37080", Offset = "0x2D36080", VA = "0x182D37080")]
		private void Flip180()
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x2D37450", Offset = "0x2D36450", VA = "0x182D37450")]
		private void OnValidate()
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204D")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void DebugLogEvents()
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x2D37370", Offset = "0x2D36370", VA = "0x182D37370")]
		private void OnEnable()
		{
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x2D37290", Offset = "0x2D36290", VA = "0x182D37290")]
		private void OnDisable()
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002050")]
		[Address(RVA = "0x2A6C550", Offset = "0x2A6B550", VA = "0x182A6C550")]
		private void OnExitedAEvent(GameObject obj)
		{
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002051")]
		[Address(RVA = "0x29B5280", Offset = "0x29B4280", VA = "0x1829B5280")]
		private void OnExitedBEvent(GameObject obj)
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public UnityEventDirectionalTrigger()
		{
		}

		// Token: 0x04001E1C RID: 7708
		[Token(Token = "0x4001E1C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DirectionalTrigger _source;

		// Token: 0x04001E1D RID: 7709
		[Token(Token = "0x4001E1D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _onExitedAEvent;

		// Token: 0x04001E1E RID: 7710
		[Token(Token = "0x4001E1E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onExitedBEvent;
	}
}
