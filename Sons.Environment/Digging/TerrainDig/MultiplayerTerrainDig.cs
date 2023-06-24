using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[AddComponentMenu("Sons/Environment/Digging/MultiplayerTerrainDig")]
	public class MultiplayerTerrainDig : MonoBehaviour
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2FB3EA0", Offset = "0x2FB24A0", VA = "0x182FB3EA0")]
		private void Awake()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2FB3F30", Offset = "0x2FB2530", VA = "0x182FB3F30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2FB40C0", Offset = "0x2FB26C0", VA = "0x182FB40C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2FB4240", Offset = "0x2FB2840", VA = "0x182FB4240")]
		private void OnDisable()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2FB43C0", Offset = "0x2FB29C0", VA = "0x182FB43C0")]
		private void OnNodeAdded(TerrainDigNode obj)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2FB4400", Offset = "0x2FB2A00", VA = "0x182FB4400")]
		private void SendDigNodeAddedEvent(TerrainDigNode terrainDigNode)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2FB4710", Offset = "0x2FB2D10", VA = "0x182FB4710")]
		private static bool BoltNetworkRunning()
		{
			return default(bool);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2FB4800", Offset = "0x2FB2E00", VA = "0x182FB4800")]
		public static void OnEvent(TerrainDigNodeAdded boltEvent)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2FB4910", Offset = "0x2FB2F10", VA = "0x182FB4910")]
		private void CreateNetworkSpawnedNode(TerrainDigNodeAdded boltEvent)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2FB50D0", Offset = "0x2FB36D0", VA = "0x182FB50D0")]
		private TerrainDigNode GetSourceNetworkSpawnedPrefab(int prominentTerrainLayer)
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2FB5140", Offset = "0x2FB3740", VA = "0x182FB5140")]
		private bool VerifyTerrainDigManager()
		{
			return default(bool);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MultiplayerTerrainDig()
		{
		}

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TerrainDigNode _sourceNetworkSpawnedPrefab;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TerrainDigObjectDefSet _terrainDigObjectDefSet;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x0")]
		private static MultiplayerTerrainDig _instance;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x30")]
		private TerrainDigManager _terrainDigManager;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _terrainHoleParent;
	}
}
