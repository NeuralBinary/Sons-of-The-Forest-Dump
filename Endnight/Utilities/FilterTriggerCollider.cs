using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Endnight.Utilities
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[AddComponentMenu("Sons/Word/FilterTriggerCollider")]
	public class FilterTriggerCollider : MonoBehaviour
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		private event Action<GameObject> _onEnter
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xA72970", Offset = "0xA70F70", VA = "0x180A72970")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xA72AE0", Offset = "0xA710E0", VA = "0x180A72AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		private event Action<GameObject> _onExit
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xA72C50", Offset = "0xA71250", VA = "0x180A72C50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xA72DC0", Offset = "0xA713C0", VA = "0x180A72DC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA72F30", Offset = "0xA71530", VA = "0x180A72F30")]
		private void OnValidate()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA73020", Offset = "0xA71620", VA = "0x180A73020")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0xA732B0", Offset = "0xA718B0", VA = "0x180A732B0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0xA73480", Offset = "0xA71A80", VA = "0x180A73480")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0xA72970", Offset = "0xA70F70", VA = "0x180A72970")]
		public void RegisterEnter(Action<GameObject> action)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0xA72C50", Offset = "0xA71250", VA = "0x180A72C50")]
		public void RegisterExit(Action<GameObject> action)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA72AE0", Offset = "0xA710E0", VA = "0x180A72AE0")]
		public void UnregisterEnter(Action<GameObject> action)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA72DC0", Offset = "0xA713C0", VA = "0x180A72DC0")]
		public void UnregisterExit(Action<GameObject> action)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA73620", Offset = "0xA71C20", VA = "0x180A73620")]
		public FilterTriggerCollider()
		{
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _trackedObjects;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _tagFilter;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent<GameObject> _onEnterUnityEvent;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent<GameObject> _onExitUnityEvent;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _autoApplyLayerMaskToColliders;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x50")]
		private List<float> _trackedObjectsTimers;
	}
}
