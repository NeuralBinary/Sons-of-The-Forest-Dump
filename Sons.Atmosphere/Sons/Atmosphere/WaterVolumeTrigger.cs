using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public class WaterVolumeTrigger : MonoBehaviour
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2D52C60", Offset = "0x2D51260", VA = "0x182D52C60", Slot = "4")]
		internal virtual void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2D52D20", Offset = "0x2D51320", VA = "0x182D52D20", Slot = "5")]
		internal virtual void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2D52DA0", Offset = "0x2D513A0", VA = "0x182D52DA0")]
		private void OnCollisionEnter(Collision other)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2D52DE0", Offset = "0x2D513E0", VA = "0x182D52DE0")]
		private void OnCollisionExit(Collision other)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2D52E20", Offset = "0x2D51420", VA = "0x182D52E20", Slot = "6")]
		internal virtual void OnEnter(Transform other)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2D52FF0", Offset = "0x2D515F0", VA = "0x182D52FF0", Slot = "7")]
		internal virtual void OnExit(Transform other)
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2D53070", Offset = "0x2D51670", VA = "0x182D53070")]
		private void Update()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2D53280", Offset = "0x2D51880", VA = "0x182D53280")]
		private void TryUpdateWetness(Component component)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WaterVolumeTrigger()
		{
		}

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x20")]
		private List<Transform> _attached;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x28")]
		private bool _hasAttached;
	}
}
