using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.VFX;

namespace Sons.Environment.Digging
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class DigTool : MonoBehaviour, IDiggingTool
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2FABAA0", Offset = "0x2FAA0A0", VA = "0x182FABAA0")]
		[Obsolete]
		public void AttachPrefab(GameObject prefabSource, Vector3 position, Quaternion rotation, VisualEffect visualEffect)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2FABFE0", Offset = "0x2FAA5E0", VA = "0x182FABFE0")]
		private void Update()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2FAC060", Offset = "0x2FAA660", VA = "0x182FAC060")]
		private void DoDetachPrefab()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600011B")]
		[Address(RVA = "0xA975F0", Offset = "0xA95BF0", VA = "0x180A975F0")]
		public void SetFinishedDigging()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2FAC470", Offset = "0x2FAAA70", VA = "0x182FAC470")]
		private void ClearAttached()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void DestroyDelay(UnityEngine.Object target)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2FAC560", Offset = "0x2FAAB60", VA = "0x182FAC560", Slot = "4")]
		public void AddActiveDiggingGroup(DiggingTileGroup groupValue)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2FAC670", Offset = "0x2FAAC70", VA = "0x182FAC670", Slot = "5")]
		public void RemoveActiveDiggingGroup(DiggingTileGroup groupValue)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2FAC6F0", Offset = "0x2FAACF0", VA = "0x182FAC6F0")]
		public DigTool()
		{
		}

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _attachedObject;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _delayBeforeDroppingAttached;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x2C")]
		private float _finishedDigging;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<DiggingTileGroup> _activeDiggingGroups;
	}
}
