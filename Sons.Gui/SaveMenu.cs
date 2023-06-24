using System;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[AddComponentMenu("Sons/Gui/SaveMenu")]
	public class SaveMenu : SaveLoadMenuBase
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x3014CD0", Offset = "0x30132D0", VA = "0x183014CD0", Slot = "4")]
		protected override void SetupSlots()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x3015170", Offset = "0x3013770", VA = "0x183015170")]
		private void SaveSlotActivated(int saveId, GameStateData data)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x30151C0", Offset = "0x30137C0", VA = "0x1830151C0")]
		private string GetCurrentGameSaveName()
		{
			return null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x3015370", Offset = "0x3013970", VA = "0x183015370")]
		private void SetCurrentGameSaveName(string gameSaveName)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x3015420", Offset = "0x3013A20", VA = "0x183015420")]
		private static bool ContainsGeneratedSaveGameName(string gameSaveName)
		{
			return default(bool);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x3015470", Offset = "0x3013A70", VA = "0x183015470")]
		private string GenerateDefaultSaveGameName()
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x30154F0", Offset = "0x3013AF0", VA = "0x1830154F0")]
		private string UpdateGenerateSaveGameName(string gameSaveName)
		{
			return null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x3015570", Offset = "0x3013B70", VA = "0x183015570")]
		private void CreateSave(string currentGameSaveName)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x3015790", Offset = "0x3013D90", VA = "0x183015790")]
		private void SaveOverwriteWithConfirmation(int saveId, string currentGameSaveName)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3010EE0", Offset = "0x300F4E0", VA = "0x183010EE0")]
		public SaveMenu()
		{
		}

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LinkTextGui _slotCountText;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		private const int MaxNumberOfSaves = 30;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		private const string DefaultSaveName = "SaveGame";
	}
}
