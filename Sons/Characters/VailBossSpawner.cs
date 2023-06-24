using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Areas;
using Sons.Save;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x0200070F RID: 1807
	[Token(Token = "0x200070F")]
	public class VailBossSpawner : MonoBehaviour
	{
		// Token: 0x06002FF9 RID: 12281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x346AB80", Offset = "0x3469180", VA = "0x18346AB80")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x0000E658 File Offset: 0x0000C858
		[Token(Token = "0x17000669")]
		public bool BossesSpawned
		{
			[Token(Token = "0x6002FFA")]
			[Address(RVA = "0x270DEE0", Offset = "0x270C4E0", VA = "0x18270DEE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x6002FFB")]
		[Address(RVA = "0x346ABC0", Offset = "0x34691C0", VA = "0x18346ABC0")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFC")]
		[Address(RVA = "0x346AC50", Offset = "0x3469250", VA = "0x18346AC50")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFD")]
		[Address(RVA = "0x346AC90", Offset = "0x3469290", VA = "0x18346AC90")]
		private void OnEnable()
		{
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x346ADF0", Offset = "0x34693F0", VA = "0x18346ADF0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x346AE80", Offset = "0x3469480", VA = "0x18346AE80")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x6003000")]
		[Address(RVA = "0x346AFE0", Offset = "0x34695E0", VA = "0x18346AFE0")]
		private static bool IsPlayer(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003001")]
		[Address(RVA = "0x346B0E0", Offset = "0x34696E0", VA = "0x18346B0E0")]
		public void TriggerSpawn()
		{
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003002")]
		[Address(RVA = "0x346B2C0", Offset = "0x34698C0", VA = "0x18346B2C0")]
		public void SetBossesSpawned(bool value)
		{
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003003")]
		[Address(RVA = "0x346B320", Offset = "0x3469920", VA = "0x18346B320")]
		private WorldSimActor SpawnBossActor(Vector3 spawnPos)
		{
			return null;
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		[Token(Token = "0x6003004")]
		[Address(RVA = "0x346B5C0", Offset = "0x3469BC0", VA = "0x18346B5C0")]
		public bool IsBossAlive()
		{
			return default(bool);
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003005")]
		[Address(RVA = "0x346B6B0", Offset = "0x3469CB0", VA = "0x18346B6B0")]
		private WorldSimActor GetBossActor()
		{
			return null;
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003006")]
		[Address(RVA = "0x346AC90", Offset = "0x3469290", VA = "0x18346AC90")]
		private void InitStateSync()
		{
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003007")]
		[Address(RVA = "0x346B780", Offset = "0x3469D80", VA = "0x18346B780")]
		private void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003008")]
		[Address(RVA = "0x346B7A0", Offset = "0x3469DA0", VA = "0x18346B7A0")]
		public VailBossSpawner()
		{
		}

		// Token: 0x04002991 RID: 10641
		[Token(Token = "0x4002991")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterDefinition _characterDefinition;

		// Token: 0x04002992 RID: 10642
		[Token(Token = "0x4002992")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _spawnCount;

		// Token: 0x04002993 RID: 10643
		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private State _spawnState;

		// Token: 0x04002994 RID: 10644
		[Token(Token = "0x4002994")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AreaMask _areaMask;

		// Token: 0x04002995 RID: 10645
		[Token(Token = "0x4002995")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _keepAboveTerrain;

		// Token: 0x04002996 RID: 10646
		[Token(Token = "0x4002996")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VailActorTypeId _actorType;

		// Token: 0x04002997 RID: 10647
		[Token(Token = "0x4002997")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _saveDataId;

		// Token: 0x04002998 RID: 10648
		[Token(Token = "0x4002998")]
		[FieldOffset(Offset = "0x68")]
		private NamedIntData _namedIntData;

		// Token: 0x04002999 RID: 10649
		[Token(Token = "0x4002999")]
		[FieldOffset(Offset = "0x70")]
		private int _numSpawned;

		// Token: 0x0400299A RID: 10650
		[Token(Token = "0x400299A")]
		[FieldOffset(Offset = "0x74")]
		private bool _bossesSpawned;

		// Token: 0x0400299B RID: 10651
		[Token(Token = "0x400299B")]
		[FieldOffset(Offset = "0x78")]
		private WorldSimActor _bossActor;
	}
}
