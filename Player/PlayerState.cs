using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Save;
using Sons.Settings;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x02000754 RID: 1876
	[Token(Token = "0x2000754")]
	public class PlayerState : MonoBehaviour, ISaveGameSerializer<PlayerStateData>
	{
		// Token: 0x060030DE RID: 12510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DE")]
		[Address(RVA = "0x2E51C40", Offset = "0x2E50C40", VA = "0x182E51C40")]
		private void Awake()
		{
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x2E525D0", Offset = "0x2E515D0", VA = "0x182E525D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061F")]
		public string SerializedName
		{
			[Token(Token = "0x60030E0")]
			[Address(RVA = "0x2E53290", Offset = "0x2E52290", VA = "0x182E53290", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x0000DE78 File Offset: 0x0000C078
		[Token(Token = "0x17000620")]
		public bool UniqueFile
		{
			[Token(Token = "0x60030E1")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x0000DE90 File Offset: 0x0000C090
		[Token(Token = "0x17000621")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x60030E2")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060030E3 RID: 12515 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		[Token(Token = "0x17000622")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x60030E3")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x2E52660", Offset = "0x2E51660", VA = "0x182E52660", Slot = "5")]
		public PlayerStateData OnSerialize()
		{
			return null;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0", Slot = "6")]
		public void OnDeserialize(PlayerStateData data)
		{
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E6")]
		[Address(RVA = "0x2E52DA0", Offset = "0x2E51DA0", VA = "0x182E52DA0")]
		public void Set(string key, int value)
		{
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E7")]
		[Address(RVA = "0x2E528F0", Offset = "0x2E518F0", VA = "0x182E528F0")]
		public void Set(string key, bool value)
		{
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E8")]
		[Address(RVA = "0x2E52EA0", Offset = "0x2E51EA0", VA = "0x182E52EA0")]
		public void Set(string key, float[] value)
		{
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E9")]
		[Address(RVA = "0x2E52A90", Offset = "0x2E51A90", VA = "0x182E52A90")]
		public void Set(string key, float value)
		{
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EA")]
		[Address(RVA = "0x2E52A00", Offset = "0x2E51A00", VA = "0x182E52A00")]
		public void Set(string key, Vector2 value)
		{
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EB")]
		[Address(RVA = "0x2E52C50", Offset = "0x2E51C50", VA = "0x182E52C50")]
		public void Set(string key, Vector3 value)
		{
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EC")]
		[Address(RVA = "0x2E52BA0", Offset = "0x2E51BA0", VA = "0x182E52BA0")]
		public void Set(string key, Vector4 value)
		{
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030ED")]
		[Address(RVA = "0x2E52CF0", Offset = "0x2E51CF0", VA = "0x182E52CF0")]
		public void Set(string key, Quaternion value)
		{
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030EE")]
		[Address(RVA = "0x2E51800", Offset = "0x2E50800", VA = "0x182E51800")]
		private PersistentValue AddEntry(string key, float value)
		{
			return null;
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030EF")]
		[Address(RVA = "0x2E51630", Offset = "0x2E50630", VA = "0x182E51630")]
		private PersistentValue AddEntry(string key, float[] value)
		{
			return null;
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F0")]
		[Address(RVA = "0x2E51720", Offset = "0x2E50720", VA = "0x182E51720")]
		private PersistentValue AddEntry(string key, int value)
		{
			return null;
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F1")]
		[Address(RVA = "0x2E518E0", Offset = "0x2E508E0", VA = "0x182E518E0")]
		private PersistentValue AddEntry(string key, bool value)
		{
			return null;
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F2")]
		[Address(RVA = "0x2E51EB0", Offset = "0x2E50EB0", VA = "0x182E51EB0")]
		private PersistentValue GetEntry(string key)
		{
			return null;
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[Token(Token = "0x60030F3")]
		[Address(RVA = "0x2E520D0", Offset = "0x2E510D0", VA = "0x182E520D0")]
		public Vector3 Get(string key, Vector2 defaultValue)
		{
			return default(Vector3);
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x2E51F10", Offset = "0x2E50F10", VA = "0x182E51F10")]
		public Vector3 Get(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x2E51FB0", Offset = "0x2E50FB0", VA = "0x182E51FB0")]
		public Vector4 Get(string key, Vector4 defaultValue)
		{
			return default(Vector4);
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x60030F6")]
		[Address(RVA = "0x2E51FB0", Offset = "0x2E50FB0", VA = "0x182E51FB0")]
		public Quaternion Get(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x60030F7")]
		[Address(RVA = "0x2E52220", Offset = "0x2E51220", VA = "0x182E52220")]
		public float Get(string key, float defaultValue = 0f)
		{
			return default(float);
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F8")]
		[Address(RVA = "0x2E52170", Offset = "0x2E51170", VA = "0x182E52170")]
		public float[] Get(string key, [Optional] float[] defaultValue)
		{
			return null;
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x60030F9")]
		[Address(RVA = "0x2E51CD0", Offset = "0x2E50CD0", VA = "0x182E51CD0")]
		public bool GetBool(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x60030FA")]
		[Address(RVA = "0x2E52070", Offset = "0x2E51070", VA = "0x182E52070")]
		public bool Get(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x0000DF68 File Offset: 0x0000C168
		[Token(Token = "0x60030FB")]
		[Address(RVA = "0x2E521D0", Offset = "0x2E511D0", VA = "0x182E521D0")]
		public int Get(string key, int defaultValue = 0)
		{
			return default(int);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FC")]
		[Address(RVA = "0x2E53050", Offset = "0x2E52050", VA = "0x182E53050")]
		private void UpdatePlayerPosition()
		{
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FD")]
		[Address(RVA = "0x2E53170", Offset = "0x2E52170", VA = "0x182E53170")]
		private void UpdatePlayerRotation()
		{
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FE")]
		[Address(RVA = "0x2E519C0", Offset = "0x2E509C0", VA = "0x182E519C0")]
		private void ApplyPlayerPositionRotationAndAreaMask()
		{
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x0000DF80 File Offset: 0x0000C180
		[Token(Token = "0x60030FF")]
		[Address(RVA = "0x2E52FC0", Offset = "0x2E51FC0", VA = "0x182E52FC0")]
		public static bool TryGetInstance(out PlayerState playerState)
		{
			return default(bool);
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003100")]
		[Address(RVA = "0x2E51ED0", Offset = "0x2E50ED0", VA = "0x182E51ED0")]
		public static PlayerState GetInstance()
		{
			return null;
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x6003101")]
		[Address(RVA = "0x2E52280", Offset = "0x2E51280", VA = "0x182E52280")]
		public bool HasConsumed(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[Token(Token = "0x6003102")]
		[Address(RVA = "0x2E51D30", Offset = "0x2E50D30", VA = "0x182E51D30")]
		public int GetConsumed(int itemId)
		{
			return default(int);
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x2E52400", Offset = "0x2E51400", VA = "0x182E52400")]
		public void IncConsumed(int itemId)
		{
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x2E52340", Offset = "0x2E51340", VA = "0x182E52340")]
		public bool HasCrafted(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		[Token(Token = "0x6003105")]
		[Address(RVA = "0x2E51DF0", Offset = "0x2E50DF0", VA = "0x182E51DF0")]
		public int GetCrafted(int itemId)
		{
			return default(int);
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003106")]
		[Address(RVA = "0x2E524D0", Offset = "0x2E514D0", VA = "0x182E524D0")]
		public void IncCrafted(int itemId)
		{
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003107")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerState()
		{
		}

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		private const string PlayerPositionKey = "player.position";

		// Token: 0x04002AC9 RID: 10953
		[Token(Token = "0x4002AC9")]
		private const string PlayerRotationKey = "player.rotation";

		// Token: 0x04002ACA RID: 10954
		[Token(Token = "0x4002ACA")]
		private const string PlayerAreaMaskKey = "player.areaMask";

		// Token: 0x04002ACB RID: 10955
		[Token(Token = "0x4002ACB")]
		private const string ConsumedKeyPrefix = "consumed.";

		// Token: 0x04002ACC RID: 10956
		[Token(Token = "0x4002ACC")]
		private const string CraftedKeyPrefix = "crafted.";

		// Token: 0x04002ACD RID: 10957
		[Token(Token = "0x4002ACD")]
		[FieldOffset(Offset = "0x0")]
		private static PlayerState _instance;

		// Token: 0x04002ACE RID: 10958
		[Token(Token = "0x4002ACE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayerStateData _data;
	}
}
