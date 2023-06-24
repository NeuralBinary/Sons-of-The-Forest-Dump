using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class ActivateOnDigCount : MonoBehaviour
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2FB2F00", Offset = "0x2FB1500", VA = "0x182FB2F00")]
		private void OnEnable()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2FB3020", Offset = "0x2FB1620", VA = "0x182FB3020")]
		private void OnDisable()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2FB3140", Offset = "0x2FB1740", VA = "0x182FB3140")]
		private void CountChanged(int count)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2FB3190", Offset = "0x2FB1790", VA = "0x182FB3190")]
		public void Activate()
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2FB31D0", Offset = "0x2FB17D0", VA = "0x182FB31D0")]
		private void SetTargets(bool value, List<GameObject> targets)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x9F3940", Offset = "0x9F1F40", VA = "0x1809F3940")]
		public ActivateOnDigCount()
		{
		}

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TerrainDigDetectionArea _source;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Min(1f)]
		private int _triggerCount;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _activateTargets;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _deactivateTargets;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x40")]
		private bool _hasActivated;
	}
}
