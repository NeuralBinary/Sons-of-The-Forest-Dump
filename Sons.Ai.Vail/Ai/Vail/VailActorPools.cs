using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	[AddComponentMenu("Sons/Ai/Vail Actor Pools")]
	public class VailActorPools : MonoBehaviour
	{
		// Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x2B560E0", Offset = "0x2B546E0", VA = "0x182B560E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public CharacterMaterials GetCharacterMaterials()
		{
			return null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2B56280", Offset = "0x2B54880", VA = "0x182B56280")]
		public void CreateActorPools()
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2B56470", Offset = "0x2B54A70", VA = "0x182B56470")]
		private void SpawnActorsInPool(VailActorPools.PoolTypeList pool)
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2B56530", Offset = "0x2B54B30", VA = "0x182B56530")]
		public bool PoolExists(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2B56690", Offset = "0x2B54C90", VA = "0x182B56690")]
		public void CreatePoolIfNeeded(VailActorTypeId typeId, VailActor prefab)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2B567D0", Offset = "0x2B54DD0", VA = "0x182B567D0")]
		private VailActorPools.PoolTypeList GetPool(VailActorTypeId typeId)
		{
			return null;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x2B56940", Offset = "0x2B54F40", VA = "0x182B56940")]
		public VailActor GetPrefab(VailActorTypeId typeId)
		{
			return null;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x2B56A10", Offset = "0x2B55010", VA = "0x182B56A10")]
		public void GetTypesForController(VailController controller, ref List<VailActorTypeId> types)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2B56D00", Offset = "0x2B55300", VA = "0x182B56D00")]
		public VailActor GetPooledActor(VailActorTypeId typeId, int uniqueId, Vector3 spawnPos, Quaternion spawnRot)
		{
			return null;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2B56F00", Offset = "0x2B55500", VA = "0x182B56F00")]
		public int GetMaxActive(VailActorTypeId typeId)
		{
			return 0;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x2B56F20", Offset = "0x2B55520", VA = "0x182B56F20")]
		private void DestroyAll()
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		public int GetMaxActiveCannibals()
		{
			return 0;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		public int GetMaxActiveCreepies()
		{
			return 0;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
		public int GetMaxActiveMuddies()
		{
			return 0;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
		public int GetMaxActiveSmallBirds()
		{
			return 0;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
		public int GetMaxActiveLargeBirds()
		{
			return 0;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
		public int GetMaxActiveSmallWildlife()
		{
			return 0;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
		public int GetMaxActiveLargeWildlife()
		{
			return 0;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2B57060", Offset = "0x2B55660", VA = "0x182B57060")]
		public void OnActorPoolStatsGUI()
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x2B576F0", Offset = "0x2B55CF0", VA = "0x182B576F0")]
		public VailActorPools()
		{
		}

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _maxCannibals;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _maxMuddies;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _maxCreepies;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _maxSmallBirds;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxLargeBirds;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _maxSmallWildlife;

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _maxLargeWildlife;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CharacterMaterials _characterMaterials;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<VailActorPools.PoolTypeList> _poolsByType;

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		[Serializable]
		private class PoolTypeList
		{
			// Token: 0x060007A4 RID: 1956 RVA: 0x000058E0 File Offset: 0x00003AE0
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x2B577D0", Offset = "0x2B55DD0", VA = "0x182B577D0")]
			private Color GetGuiColor()
			{
				return default(Color);
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x2B578B0", Offset = "0x2B55EB0", VA = "0x182B578B0")]
			public VailActor GetInactiveActor(int uniqueId)
			{
				return null;
			}

			// Token: 0x060007A6 RID: 1958 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x2B57AA0", Offset = "0x2B560A0", VA = "0x182B57AA0")]
			public VailActor SpawnActor(Vector3 spawnPos, Quaternion spawnRot)
			{
				return null;
			}

			// Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x2B57DD0", Offset = "0x2B563D0", VA = "0x182B57DD0")]
			public void DestroyAll()
			{
			}

			// Token: 0x060007A8 RID: 1960 RVA: 0x000058F8 File Offset: 0x00003AF8
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x2B58020", Offset = "0x2B56620", VA = "0x182B58020")]
			public int ActiveCount()
			{
				return 0;
			}

			// Token: 0x060007A9 RID: 1961 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x2B58180", Offset = "0x2B56780", VA = "0x182B58180")]
			private void RemoveNullsAndDead()
			{
			}

			// Token: 0x060007AA RID: 1962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x2B58350", Offset = "0x2B56950", VA = "0x182B58350")]
			public PoolTypeList()
			{
			}

			// Token: 0x04000605 RID: 1541
			[Token(Token = "0x4000605")]
			[FieldOffset(Offset = "0x10")]
			public VailActorTypeId id;

			// Token: 0x04000606 RID: 1542
			[Token(Token = "0x4000606")]
			[FieldOffset(Offset = "0x18")]
			public VailActor prefab;

			// Token: 0x04000607 RID: 1543
			[Token(Token = "0x4000607")]
			[FieldOffset(Offset = "0x20")]
			public bool reusable;

			// Token: 0x04000608 RID: 1544
			[Token(Token = "0x4000608")]
			[FieldOffset(Offset = "0x24")]
			public int maxActive;

			// Token: 0x04000609 RID: 1545
			[Token(Token = "0x4000609")]
			[FieldOffset(Offset = "0x28")]
			public float powerLevel;

			// Token: 0x0400060A RID: 1546
			[Token(Token = "0x400060A")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public List<VailActor> _actors;
		}
	}
}
