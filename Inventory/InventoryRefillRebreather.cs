using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005FA RID: 1530
	[Token(Token = "0x20005FA")]
	[AddComponentMenu("Sons/Inventory/InventoryRefillRebreather")]
	public class InventoryRefillRebreather : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x06002728 RID: 10024 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x2DBADA0", Offset = "0x2DB9DA0", VA = "0x182DBADA0", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x2DBAFF0", Offset = "0x2DB9FF0", VA = "0x182DBAFF0")]
		private void Update()
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x2DBAD20", Offset = "0x2DB9D20", VA = "0x182DBAD20")]
		private void OnDisable()
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x553EB0", Offset = "0x552EB0", VA = "0x180553EB0")]
		public InventoryRefillRebreather()
		{
		}

		// Token: 0x0400236A RID: 9066
		[Token(Token = "0x400236A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[EventRef]
		private string _airRefillAudioEvent;

		// Token: 0x0400236B RID: 9067
		[Token(Token = "0x400236B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Min(0f)]
		private float _airRefillRate;

		// Token: 0x0400236C RID: 9068
		[Token(Token = "0x400236C")]
		[FieldOffset(Offset = "0x30")]
		private VolumeContainerItemInstanceModule _volumeModule;

		// Token: 0x0400236D RID: 9069
		[Token(Token = "0x400236D")]
		[FieldOffset(Offset = "0x38")]
		private EventInstance _airRefillSfxEvent;

		// Token: 0x0400236E RID: 9070
		[Token(Token = "0x400236E")]
		[FieldOffset(Offset = "0x40")]
		private bool _isRefilling;
	}
}
