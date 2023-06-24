using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x02000825 RID: 2085
	[Token(Token = "0x2000825")]
	public class ZipLineManager : SingletonBehaviour<ZipLineManager>, ISaveGameSerializer<ZipLineManager.ZipLineManagerSaveData>
	{
		// Token: 0x06003ABB RID: 15035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ABB")]
		[Address(RVA = "0x357C880", Offset = "0x357AE80", VA = "0x18357C880")]
		public ZipLineController CreateZipLine(Vector3 anchorAPosition, Vector3 anchorBPosition, bool canBeDismantled, WorldLocatorId anchorATreeId, WorldLocatorId anchorBTreeId)
		{
			return null;
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ABC")]
		[Address(RVA = "0x357CF70", Offset = "0x357B570", VA = "0x18357CF70")]
		public void RegisterZipLine(ZipLineController zipLineController)
		{
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ABD")]
		[Address(RVA = "0x357D020", Offset = "0x357B620", VA = "0x18357D020")]
		public void RemoveZipLine(ZipLineController zipLineController, bool remoteRemove = false)
		{
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ABE")]
		[Address(RVA = "0x357D1C0", Offset = "0x357B7C0", VA = "0x18357D1C0")]
		private void Start()
		{
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ABF")]
		[Address(RVA = "0x357D2C0", Offset = "0x357B8C0", VA = "0x18357D2C0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC0")]
		[Address(RVA = "0x357D390", Offset = "0x357B990", VA = "0x18357D390")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC1")]
		[Address(RVA = "0x357D3F0", Offset = "0x357B9F0", VA = "0x18357D3F0", Slot = "11")]
		private ZipLineManager.ZipLineManagerSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC2")]
		[Address(RVA = "0x357D860", Offset = "0x357BE60", VA = "0x18357D860", Slot = "12")]
		private void OnDeserialize(ZipLineManager.ZipLineManagerSaveData data)
		{
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A3")]
		private string SerializedName
		{
			[Token(Token = "0x6003AC3")]
			[Address(RVA = "0x357DA20", Offset = "0x357C020", VA = "0x18357DA20", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x00011FB8 File Offset: 0x000101B8
		[Token(Token = "0x170007A4")]
		private bool UniqueFile
		{
			[Token(Token = "0x6003AC4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x00011FD0 File Offset: 0x000101D0
		[Token(Token = "0x170007A5")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6003AC5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x00011FE8 File Offset: 0x000101E8
		[Token(Token = "0x170007A6")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6003AC6")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC7")]
		[Address(RVA = "0x357DA50", Offset = "0x357C050", VA = "0x18357DA50")]
		public ZipLineManager()
		{
		}

		// Token: 0x0400320A RID: 12810
		[Token(Token = "0x400320A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ZipLineController _zipLineControllerAsset;

		// Token: 0x0400320B RID: 12811
		[Token(Token = "0x400320B")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<ZipLineController> _ziplines;

		// Token: 0x02000826 RID: 2086
		[Token(Token = "0x2000826")]
		[Serializable]
		internal class ZipLineManagerSaveData
		{
			// Token: 0x06003AC8 RID: 15048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AC8")]
			[Address(RVA = "0x357DB40", Offset = "0x357C140", VA = "0x18357DB40")]
			public ZipLineManagerSaveData()
			{
			}

			// Token: 0x0400320C RID: 12812
			[Token(Token = "0x400320C")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x0400320D RID: 12813
			[Token(Token = "0x400320D")]
			[FieldOffset(Offset = "0x18")]
			public List<ZipLineManager.ZipLineManagerSaveData.ZipLineSaveData> Ziplines;

			// Token: 0x02000827 RID: 2087
			[Token(Token = "0x2000827")]
			[Serializable]
			public class ZipLineSaveData
			{
				// Token: 0x06003AC9 RID: 15049 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003AC9")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public ZipLineSaveData()
				{
				}

				// Token: 0x0400320E RID: 12814
				[Token(Token = "0x400320E")]
				[FieldOffset(Offset = "0x10")]
				public Vector3S _anchorAPosition;

				// Token: 0x0400320F RID: 12815
				[Token(Token = "0x400320F")]
				[FieldOffset(Offset = "0x1C")]
				public Vector3S _anchorBPosition;

				// Token: 0x04003210 RID: 12816
				[Token(Token = "0x4003210")]
				[FieldOffset(Offset = "0x28")]
				public bool _canBeDismantled;
			}
		}
	}
}
