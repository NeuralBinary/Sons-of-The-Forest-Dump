using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x020006D9 RID: 1753
	[Token(Token = "0x20006D9")]
	public class ZipLineManager : SingletonBehaviour<ZipLineManager>, ISaveGameSerializer<ZipLineManager.ZipLineManagerSaveData>
	{
		// Token: 0x06002CD8 RID: 11480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x2E1FF60", Offset = "0x2E1EF60", VA = "0x182E1FF60")]
		public ZipLineController CreateZipLine(Vector3 anchorAPosition, Vector3 anchorBPosition, bool canBeDismantled, WorldLocatorId anchorATreeId, WorldLocatorId anchorBTreeId)
		{
			return null;
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x2E20330", Offset = "0x2E1F330", VA = "0x182E20330")]
		public void RegisterZipLine(ZipLineController zipLineController)
		{
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x2E20410", Offset = "0x2E1F410", VA = "0x182E20410")]
		public void RemoveZipLine(ZipLineController zipLineController, bool remoteRemove = false)
		{
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x2E20A20", Offset = "0x2E1FA20", VA = "0x182E20A20")]
		private void Start()
		{
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x2E20260", Offset = "0x2E1F260", VA = "0x182E20260", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x2E1FF00", Offset = "0x2E1EF00", VA = "0x182E1FF00")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x2E206D0", Offset = "0x2E1F6D0", VA = "0x182E206D0", Slot = "11")]
		private ZipLineManager.ZipLineManagerSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDF")]
		[Address(RVA = "0x2E20530", Offset = "0x2E1F530", VA = "0x182E20530", Slot = "12")]
		private void OnDeserialize(ZipLineManager.ZipLineManagerSaveData data)
		{
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A0")]
		private string SerializedName
		{
			[Token(Token = "0x6002CE0")]
			[Address(RVA = "0x2E209F0", Offset = "0x2E1F9F0", VA = "0x182E209F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[Token(Token = "0x170005A1")]
		private bool UniqueFile
		{
			[Token(Token = "0x6002CE1")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x170005A2")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6002CE2")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x170005A3")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6002CE3")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE4")]
		[Address(RVA = "0x2E20B20", Offset = "0x2E1FB20", VA = "0x182E20B20")]
		public ZipLineManager()
		{
		}

		// Token: 0x0400282E RID: 10286
		[Token(Token = "0x400282E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ZipLineController _zipLineControllerAsset;

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<ZipLineController> _ziplines;

		// Token: 0x020006DA RID: 1754
		[Token(Token = "0x20006DA")]
		[Serializable]
		internal class ZipLineManagerSaveData
		{
			// Token: 0x06002CE5 RID: 11493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CE5")]
			[Address(RVA = "0x2E1FE60", Offset = "0x2E1EE60", VA = "0x182E1FE60")]
			public ZipLineManagerSaveData()
			{
			}

			// Token: 0x04002830 RID: 10288
			[Token(Token = "0x4002830")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04002831 RID: 10289
			[Token(Token = "0x4002831")]
			[FieldOffset(Offset = "0x18")]
			public List<ZipLineManager.ZipLineManagerSaveData.ZipLineSaveData> Ziplines;

			// Token: 0x020006DB RID: 1755
			[Token(Token = "0x20006DB")]
			[Serializable]
			public class ZipLineSaveData
			{
				// Token: 0x06002CE6 RID: 11494 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002CE6")]
				[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
				public ZipLineSaveData()
				{
				}

				// Token: 0x04002832 RID: 10290
				[Token(Token = "0x4002832")]
				[FieldOffset(Offset = "0x10")]
				public Vector3S _anchorAPosition;

				// Token: 0x04002833 RID: 10291
				[Token(Token = "0x4002833")]
				[FieldOffset(Offset = "0x1C")]
				public Vector3S _anchorBPosition;

				// Token: 0x04002834 RID: 10292
				[Token(Token = "0x4002834")]
				[FieldOffset(Offset = "0x28")]
				public bool _canBeDismantled;
			}
		}
	}
}
