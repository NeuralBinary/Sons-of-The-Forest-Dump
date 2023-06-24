using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[AddComponentMenu("Endnight/Utilities/PlayerLocation")]
	public class PlayerLocation : EntityBehaviour<IPlayerState>
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x17000016")]
		public int AreaMask
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x17000017")]
		public bool IsLocalPlayer
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x17000018")]
		public bool IsActive
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x9962C0", Offset = "0x9948C0", VA = "0x1809962C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA88320", Offset = "0xA86920", VA = "0x180A88320")]
		private void OnEnable()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA88420", Offset = "0xA86A20", VA = "0x180A88420")]
		private void OnDisable()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA88590", Offset = "0xA86B90", VA = "0x180A88590")]
		private void TestSetAreaMaskMp()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA885A0", Offset = "0xA86BA0", VA = "0x180A885A0")]
		public void SetAreaMask(int areaMask)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x9962D0", Offset = "0x9948D0", VA = "0x1809962D0")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA885B0", Offset = "0xA86BB0", VA = "0x180A885B0")]
		private void MultiplayerSetAreaMask(int areaMask)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA88760", Offset = "0xA86D60", VA = "0x180A88760", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA88870", Offset = "0xA86E70", VA = "0x180A88870")]
		private void OnAreaMaskChanged()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA88910", Offset = "0xA86F10", VA = "0x180A88910")]
		private static void Register(PlayerLocation location)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA889E0", Offset = "0xA86FE0", VA = "0x180A889E0")]
		private static void Unregister(PlayerLocation location)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA88B20", Offset = "0xA87120", VA = "0x180A88B20")]
		public static void SetLocalPlayerAreaMask(int caveMask)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA88CA0", Offset = "0xA872A0", VA = "0x180A88CA0")]
		public static int GetPlayerCount()
		{
			return 0;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA88D10", Offset = "0xA87310", VA = "0x180A88D10")]
		public static int GetActivePlayerCount()
		{
			return 0;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA88E90", Offset = "0xA87490", VA = "0x180A88E90")]
		public static Vector3 GetFirst(out int areaMask, bool onlyActive = true)
		{
			return default(Vector3);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA89190", Offset = "0xA87790", VA = "0x180A89190")]
		public static void Init()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA89290", Offset = "0xA87890", VA = "0x180A89290")]
		public static void UpdatePlayersAndViewers()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA899A0", Offset = "0xA87FA0", VA = "0x180A899A0")]
		public static bool NearAnyPlayer(Vector3 checkPos, float nearDist, bool checkLocal = true)
		{
			return default(bool);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA89C10", Offset = "0xA88210", VA = "0x180A89C10")]
		public static Vector3 GetClosestPlayerPosition(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA89DD0", Offset = "0xA883D0", VA = "0x180A89DD0")]
		public static float GetClosestPlayerDistance(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xA89F20", Offset = "0xA88520", VA = "0x180A89F20")]
		public static int GetPlayerPositions(out Vector3[] playerPositions)
		{
			return 0;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xA89FD0", Offset = "0xA885D0", VA = "0x180A89FD0")]
		public static int GetLocalPlayerAreaMask()
		{
			return 0;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xA8A240", Offset = "0xA88840", VA = "0x180A8A240")]
		public static bool IsInPlayerView(Vector3 position, float maxPlayerDistance, float alwaysTrueDistance = 0f)
		{
			return default(bool);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xA8A4F0", Offset = "0xA88AF0", VA = "0x180A8A4F0")]
		public static List<PlayerLocation.ViewerInfo> GetLocalViewer()
		{
			return null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xA8A770", Offset = "0xA88D70", VA = "0x180A8A770")]
		public static List<PlayerLocation.ViewerInfo> GetViewerList()
		{
			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xA8A7C0", Offset = "0xA88DC0", VA = "0x180A8A7C0")]
		public static int GetAreaMaskAllPlayers()
		{
			return 0;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xA8A940", Offset = "0xA88F40", VA = "0x180A8A940")]
		public PlayerLocation()
		{
		}

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		private const int MaxPlayers = 32;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3 ViewHeightOffset;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		public const float PlayerCapsuleHeight = 1.4f;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isLocalPlayer;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x29")]
		private bool _isActive;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x2C")]
		private int _areaMask;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<PlayerLocation> _players;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x18")]
		private static int _playerPositionCount;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x20")]
		private static Vector3[] _playerPositions;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x28")]
		private static readonly List<PlayerLocation.ViewerInfo> _viewers;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x30")]
		private static List<PlayerLocation.ViewerInfo> _localViewer;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x38")]
		private static int _activeWorldLocationIdx;

		// Token: 0x0200004D RID: 77
		[Token(Token = "0x200004D")]
		public struct ViewerInfo
		{
			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 Position;

			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 Forward;

			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x18")]
			public int AreaMask;

			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x1C")]
			public bool IsLocal;

			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			[FieldOffset(Offset = "0x1D")]
			public bool IsCamera;
		}
	}
}
