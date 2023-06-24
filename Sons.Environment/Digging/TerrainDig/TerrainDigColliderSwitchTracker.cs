using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public class TerrainDigColliderSwitchTracker : MonoBehaviour
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2FBBE80", Offset = "0x2FBA480", VA = "0x182FBBE80")]
		private void LateUpdate()
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2FBBE90", Offset = "0x2FBA490", VA = "0x182FBBE90")]
		private void SafetyCleanApplied()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2FBC580", Offset = "0x2FBAB80", VA = "0x182FBC580")]
		private void Awake()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2FBC630", Offset = "0x2FBAC30", VA = "0x182FBC630")]
		public void RegisterSwitch(TerrainDigColliderSwitch terrainDigColliderSwitch, Collider other)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2FBC8B0", Offset = "0x2FBAEB0", VA = "0x182FBC8B0")]
		private static void SetIgnore(Collider other, bool ignore)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2FBCAA0", Offset = "0x2FBB0A0", VA = "0x182FBCAA0")]
		private static void ValidateTerrainColliders()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2FBCF40", Offset = "0x2FBB540", VA = "0x182FBCF40")]
		public void UnregisterSwitch(TerrainDigColliderSwitch terrainDigColliderSwitch, Collider other)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2FBD240", Offset = "0x2FBB840", VA = "0x182FBD240")]
		public TerrainDigColliderSwitchTracker()
		{
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x20")]
		private int _activeColliders;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Collider, List<TerrainDigColliderSwitch>> _appliedColliders;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x0")]
		private static List<Collider> _terrainCollisionCache;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x8")]
		private static int _terrainCollisionCacheFrame;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x30")]
		private List<Collider> _collidersToRemoveBuffer;
	}
}
