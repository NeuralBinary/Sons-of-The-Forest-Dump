using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Gameplay.Gardening
{
	// Token: 0x02000866 RID: 2150
	[Token(Token = "0x2000866")]
	public class GardenPlotSaveManager : SingletonBehaviour<GardenPlotSaveManager>, ISaveGameSerializer<GardenPlotSaveManager.GardenPlotManagerSaveData>
	{
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EC")]
		private string SerializedName
		{
			[Token(Token = "0x6003D47")]
			[Address(RVA = "0x35B9D00", Offset = "0x35B8300", VA = "0x1835B9D00", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003D48 RID: 15688 RVA: 0x00012B10 File Offset: 0x00010D10
		[Token(Token = "0x170007ED")]
		private bool UniqueFile
		{
			[Token(Token = "0x6003D48")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x00012B28 File Offset: 0x00010D28
		[Token(Token = "0x170007EE")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6003D49")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x00012B40 File Offset: 0x00010D40
		[Token(Token = "0x170007EF")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6003D4A")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4B")]
		[Address(RVA = "0x35B9D30", Offset = "0x35B8330", VA = "0x1835B9D30")]
		private void Start()
		{
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4C")]
		[Address(RVA = "0x35B9E60", Offset = "0x35B8460", VA = "0x1835B9E60", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x35B9F10", Offset = "0x35B8510", VA = "0x1835B9F10")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x35B9FA0", Offset = "0x35B85A0", VA = "0x1835B9FA0")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4F")]
		[Address(RVA = "0x35B9FF0", Offset = "0x35B85F0", VA = "0x1835B9FF0")]
		public static void Register(GardenPlot plot)
		{
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x35BA120", Offset = "0x35B8720", VA = "0x1835BA120")]
		public static void Unregister(GardenPlot plot)
		{
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x35BA210", Offset = "0x35B8810", VA = "0x1835BA210", Slot = "11")]
		private GardenPlotSaveManager.GardenPlotManagerSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x35BA5D0", Offset = "0x35B8BD0", VA = "0x1835BA5D0", Slot = "12")]
		private void OnDeserialize(GardenPlotSaveManager.GardenPlotManagerSaveData data)
		{
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x35BA730", Offset = "0x35B8D30", VA = "0x1835BA730")]
		public GardenPlotSaveManager()
		{
		}

		// Token: 0x040033C5 RID: 13253
		[Token(Token = "0x40033C5")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x040033C6 RID: 13254
		[Token(Token = "0x40033C6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<GardenPlot> _gardenPlots;

		// Token: 0x02000867 RID: 2151
		[Token(Token = "0x2000867")]
		[Serializable]
		public class GardenPlotManagerSaveData
		{
			// Token: 0x06003D55 RID: 15701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D55")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public GardenPlotManagerSaveData()
			{
			}

			// Token: 0x040033C7 RID: 13255
			[Token(Token = "0x40033C7")]
			[FieldOffset(Offset = "0x10")]
			public List<GardenPlot.GardenPlotData> _gardenPlotsData;
		}
	}
}
