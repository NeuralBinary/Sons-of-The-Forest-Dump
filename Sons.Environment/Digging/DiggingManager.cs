using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.VFX;

namespace Sons.Environment.Digging
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class DiggingManager : SingletonBehaviour<DiggingManager>
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2F9DAA0", Offset = "0x2F9C0A0", VA = "0x182F9DAA0")]
		public static void Register(DiggingTileGroup targetGroup)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2F9DC60", Offset = "0x2F9C260", VA = "0x182F9DC60")]
		private void Update()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2F9E030", Offset = "0x2F9C630", VA = "0x182F9E030")]
		public static void Unregister(DiggingTileGroup targetGroup)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2F9E100", Offset = "0x2F9C700", VA = "0x182F9E100")]
		public static bool TryGetClosestTile(Vector3 worldLocation, out DiggingTileGroup resultGroup, out DiggingTile resultTile, out float resultDistance, bool ignoreY = false)
		{
			return default(bool);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2F9E300", Offset = "0x2F9C900", VA = "0x182F9E300")]
		public static bool TryGetClosest(Vector3 worldLocation, out DiggingTileGroup result, out float resultDistance, bool ignoreY = false)
		{
			return default(bool);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2F9E680", Offset = "0x2F9CC80", VA = "0x182F9E680")]
		public static void TriggerDigParticle(VisualEffect targetVisualEffect, string eventName, Vector3 transformPosition, string digParticlePositionName, float digDir, float particleAngle, List<KeyFloatPair> floats)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2F9E9C0", Offset = "0x2F9CFC0", VA = "0x182F9E9C0")]
		public static void SpawnDigParticle(float digDirection, GameObject particlePrefab, string particleNameSuffix, Vector3 position, Vector3 localRotation, Transform targetParent)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2F9ED30", Offset = "0x2F9D330", VA = "0x182F9ED30")]
		public DiggingManager()
		{
		}

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _activateDistance;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		private static List<DiggingTileGroup> _groups;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x30")]
		private Transform _activeWorldTransform;
	}
}
