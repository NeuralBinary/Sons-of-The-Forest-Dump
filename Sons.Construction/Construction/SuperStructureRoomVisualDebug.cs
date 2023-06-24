using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	[AddComponentMenu("Sons/Construction/SuperStructureRoomVisualDebug")]
	public class SuperStructureRoomVisualDebug : MonoBehaviour, ISuperStructureRefreshedReceiver
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2E0AE70", Offset = "0x2E09470", VA = "0x182E0AE70")]
		private void Awake()
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2E0AF60", Offset = "0x2E09560", VA = "0x182E0AF60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x26AB660", Offset = "0x26A9C60", VA = "0x1826AB660")]
		private void ToggleSuperStructureRoomsVisualDebug(bool onOff)
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2E0AFC0", Offset = "0x2E095C0", VA = "0x182E0AFC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2E0B110", Offset = "0x2E09710", VA = "0x182E0B110")]
		private void OnDisable()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2E0B1A0", Offset = "0x2E097A0", VA = "0x182E0B1A0")]
		private void CleanUpVisuals()
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2E0B3F0", Offset = "0x2E099F0", VA = "0x182E0B3F0")]
		private void GenerateVisuals()
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2E0BAB0", Offset = "0x2E0A0B0", VA = "0x182E0BAB0", Slot = "4")]
		private void OnRefreshedSuperStructures()
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2E0BAD0", Offset = "0x2E0A0D0", VA = "0x182E0BAD0")]
		public SuperStructureRoomVisualDebug()
		{
		}

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material _sealedRoomsMat;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material _nonSealedRoomsMat;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x30")]
		private List<Transform> _visuals;
	}
}
