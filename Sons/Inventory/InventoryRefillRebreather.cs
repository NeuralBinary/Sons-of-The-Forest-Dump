using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x0200060C RID: 1548
	[Token(Token = "0x200060C")]
	[AddComponentMenu("Sons/Inventory/InventoryRefillRebreather")]
	public class InventoryRefillRebreather : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x06002832 RID: 10290 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x33D7D40", Offset = "0x33D6340", VA = "0x1833D7D40", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002833")]
		[Address(RVA = "0x33D7FC0", Offset = "0x33D65C0", VA = "0x1833D7FC0")]
		private void Update()
		{
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x33D80B0", Offset = "0x33D66B0", VA = "0x1833D80B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
		public InventoryRefillRebreather()
		{
		}

		// Token: 0x0400244E RID: 9294
		[Token(Token = "0x400244E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[EventRef]
		private string _airRefillAudioEvent;

		// Token: 0x0400244F RID: 9295
		[Token(Token = "0x400244F")]
		[FieldOffset(Offset = "0x28")]
		[Min(0f)]
		[SerializeField]
		private float _airRefillRate;

		// Token: 0x04002450 RID: 9296
		[Token(Token = "0x4002450")]
		[FieldOffset(Offset = "0x30")]
		private VolumeContainerItemInstanceModule _volumeModule;

		// Token: 0x04002451 RID: 9297
		[Token(Token = "0x4002451")]
		[FieldOffset(Offset = "0x38")]
		private EventInstance _airRefillSfxEvent;

		// Token: 0x04002452 RID: 9298
		[Token(Token = "0x4002452")]
		[FieldOffset(Offset = "0x40")]
		private bool _isRefilling;
	}
}
