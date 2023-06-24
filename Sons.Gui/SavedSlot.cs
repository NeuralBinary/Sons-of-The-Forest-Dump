using System;
using Il2CppDummyDll;
using Sons.Save;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class SavedSlot : SaveSlotBase
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x3010F80", Offset = "0x300F580", VA = "0x183010F80")]
		public void Setup(Texture thumbnail, DateTime dateTime, GameStateData saveData, uint days, string gameType, string gameName, uint saveId, Action<int, GameStateData> buttonAction, Action<int, GameStateData> buttonDeleteAction, SaveGameType saveGameType)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x3011460", Offset = "0x300FA60", VA = "0x183011460")]
		public void Setup(Texture thumbnail, DateTime dateTime, GameStateData saveData, uint days, string gameType, string gameName, int slot, Action<int, GameStateData> buttonAction, Action<int, GameStateData> buttonDeleteAction)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x3011940", Offset = "0x300FF40", VA = "0x183011940", Slot = "6")]
		internal override void RemoveButton()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x3011990", Offset = "0x300FF90", VA = "0x183011990")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x30119A0", Offset = "0x300FFA0", VA = "0x1830119A0")]
		private void DisposeExistingThumbnailTexture()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x3011A40", Offset = "0x3010040", VA = "0x183011A40", Slot = "4")]
		internal override void OnButton()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x3011A60", Offset = "0x3010060", VA = "0x183011A60", Slot = "5")]
		internal override void OnButtonDelete()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x3011A80", Offset = "0x3010080", VA = "0x183011A80")]
		private string FormatGameName(string gameName)
		{
			return null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x3011AF0", Offset = "0x30100F0", VA = "0x183011AF0")]
		private string FormatGameInfo(uint days, string gameType)
		{
			return null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x3011C50", Offset = "0x3010250", VA = "0x183011C50")]
		private static string FormatDateTime(DateTime source)
		{
			return null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x3011DB0", Offset = "0x30103B0", VA = "0x183011DB0")]
		public void Setup(Texture thumbnail, GameStateData saveData, uint saveId, Action<int, GameStateData> buttonAction, Action<int, GameStateData> buttonDeleteAction, SaveGameType saveGameType)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x3011E60", Offset = "0x3010460", VA = "0x183011E60")]
		public void Setup(Texture thumbnail, GameStateData saveData, int slotIndex, Action<int, GameStateData> buttonAction, Action<int, GameStateData> buttonDeleteAction)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
		public DateTime GetDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SavedSlot()
		{
		}

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		private const string DateReplaceString = "{date}";

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		private const string TimeReplaceString = "{time}";

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		private const string DayReplaceString = "{dayCount}";

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		private const string GameTypeReplaceString = "{difficulty}";

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		private const string GameNameReplaceString = "{saveName}";

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RawImage _thumbnailImage;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TMP_Text _dateTimeLabel;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TMP_Text _gameInfoLabel;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TMP_Text _gameNameLabel;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _removeObjectRoot;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x0")]
		private static string _defaultDateTimeText;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x8")]
		private static string _defaultGameInfoText;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x10")]
		private static string _defaultGameNameText;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x78")]
		private Action<int, GameStateData> _buttonAction;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x80")]
		private Action<int, GameStateData> _buttonDeleteAction;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x88")]
		private DateTime _dateTime;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x90")]
		private bool _destroyThumbnailTexture;
	}
}
