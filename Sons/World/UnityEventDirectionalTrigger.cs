using System;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.World
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	[AddComponentMenu("Sons/Word/Directional Trigger (Unity event)")]
	public class UnityEventDirectionalTrigger : MonoBehaviour
	{
		// Token: 0x060020BE RID: 8382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x331D410", Offset = "0x331BA10", VA = "0x18331D410")]
		private void Flip180()
		{
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x331D760", Offset = "0x331BD60", VA = "0x18331D760")]
		private void OnValidate()
		{
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void DebugLogEvents()
		{
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x331D890", Offset = "0x331BE90", VA = "0x18331D890")]
		private void OnEnable()
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x331D970", Offset = "0x331BF70", VA = "0x18331D970")]
		private void OnDisable()
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x3064BA0", Offset = "0x30631A0", VA = "0x183064BA0")]
		private void OnExitedAEvent(GameObject obj)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x2F85160", Offset = "0x2F83760", VA = "0x182F85160")]
		private void OnExitedBEvent(GameObject obj)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UnityEventDirectionalTrigger()
		{
		}

		// Token: 0x04001E77 RID: 7799
		[Token(Token = "0x4001E77")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DirectionalTrigger _source;

		// Token: 0x04001E78 RID: 7800
		[Token(Token = "0x4001E78")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _onExitedAEvent;

		// Token: 0x04001E79 RID: 7801
		[Token(Token = "0x4001E79")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onExitedBEvent;
	}
}
