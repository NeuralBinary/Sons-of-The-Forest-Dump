using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Save;
using Sons.Settings;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x0200065F RID: 1631
	[Token(Token = "0x200065F")]
	public class PlayerState : MonoBehaviour, ISaveGameSerializer<PlayerStateData>
	{
		// Token: 0x06002A4F RID: 10831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x33F9EE0", Offset = "0x33F84E0", VA = "0x1833F9EE0")]
		private void Awake()
		{
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A50")]
		[Address(RVA = "0x33F9FB0", Offset = "0x33F85B0", VA = "0x1833F9FB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058A")]
		public string SerializedName
		{
			[Token(Token = "0x6002A51")]
			[Address(RVA = "0x33FA080", Offset = "0x33F8680", VA = "0x1833FA080", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x1700058B")]
		public bool UniqueFile
		{
			[Token(Token = "0x6002A52")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x1700058C")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x6002A53")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x1700058D")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x6002A54")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x33FA0B0", Offset = "0x33F86B0", VA = "0x1833FA0B0", Slot = "5")]
		public PlayerStateData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x33FA3B0", Offset = "0x33F89B0", VA = "0x1833FA3B0", Slot = "6")]
		public void OnDeserialize(PlayerStateData data)
		{
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x33FA410", Offset = "0x33F8A10", VA = "0x1833FA410")]
		public void Set(string key, int value)
		{
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x33FA5B0", Offset = "0x33F8BB0", VA = "0x1833FA5B0")]
		public void Set(string key, bool value)
		{
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x33FA750", Offset = "0x33F8D50", VA = "0x1833FA750")]
		public void Set(string key, float[] value)
		{
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x33FA800", Offset = "0x33F8E00", VA = "0x1833FA800")]
		public void Set(string key, float value)
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x33FA9A0", Offset = "0x33F8FA0", VA = "0x1833FA9A0")]
		public void Set(string key, Vector2 value)
		{
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0x33FAA30", Offset = "0x33F9030", VA = "0x1833FAA30")]
		public void Set(string key, Vector3 value)
		{
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x33FAAD0", Offset = "0x33F90D0", VA = "0x1833FAAD0")]
		public void Set(string key, Vector4 value)
		{
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x33FAB80", Offset = "0x33F9180", VA = "0x1833FAB80")]
		public void Set(string key, Quaternion value)
		{
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5F")]
		[Address(RVA = "0x33FAC30", Offset = "0x33F9230", VA = "0x1833FAC30")]
		private PersistentValue AddEntry(string key, float value)
		{
			return null;
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A60")]
		[Address(RVA = "0x33FADA0", Offset = "0x33F93A0", VA = "0x1833FADA0")]
		private PersistentValue AddEntry(string key, float[] value)
		{
			return null;
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x33FAF70", Offset = "0x33F9570", VA = "0x1833FAF70")]
		private PersistentValue AddEntry(string key, int value)
		{
			return null;
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A62")]
		[Address(RVA = "0x33FB0F0", Offset = "0x33F96F0", VA = "0x1833FB0F0")]
		private PersistentValue AddEntry(string key, bool value)
		{
			return null;
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A63")]
		[Address(RVA = "0x33FB270", Offset = "0x33F9870", VA = "0x1833FB270")]
		private PersistentValue GetEntry(string key)
		{
			return null;
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x6002A64")]
		[Address(RVA = "0x33FB290", Offset = "0x33F9890", VA = "0x1833FB290")]
		public Vector3 Get(string key, Vector2 defaultValue)
		{
			return default(Vector3);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x6002A65")]
		[Address(RVA = "0x33FB320", Offset = "0x33F9920", VA = "0x1833FB320")]
		public Vector3 Get(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x6002A66")]
		[Address(RVA = "0x33FB3C0", Offset = "0x33F99C0", VA = "0x1833FB3C0")]
		public Vector4 Get(string key, Vector4 defaultValue)
		{
			return default(Vector4);
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x33FB3C0", Offset = "0x33F99C0", VA = "0x1833FB3C0")]
		public Quaternion Get(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x33FB460", Offset = "0x33F9A60", VA = "0x1833FB460")]
		public float Get(string key, float defaultValue = 0f)
		{
			return 0f;
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A69")]
		[Address(RVA = "0x33FB4B0", Offset = "0x33F9AB0", VA = "0x1833FB4B0")]
		public float[] Get(string key, [Optional] float[] defaultValue)
		{
			return null;
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x33FB4F0", Offset = "0x33F9AF0", VA = "0x1833FB4F0")]
		public bool GetBool(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x33FB4F0", Offset = "0x33F9AF0", VA = "0x1833FB4F0")]
		public bool Get(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x0000C810 File Offset: 0x0000AA10
		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x33FB530", Offset = "0x33F9B30", VA = "0x1833FB530")]
		public int Get(string key, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6D")]
		[Address(RVA = "0x33FB570", Offset = "0x33F9B70", VA = "0x1833FB570")]
		private void UpdatePlayerPosition()
		{
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0x33FB6C0", Offset = "0x33F9CC0", VA = "0x1833FB6C0")]
		private void UpdatePlayerRotation()
		{
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6F")]
		[Address(RVA = "0x33FB820", Offset = "0x33F9E20", VA = "0x1833FB820")]
		private void ApplyPlayerPositionRotationAndAreaMask()
		{
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x0000C828 File Offset: 0x0000AA28
		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x33FBDD0", Offset = "0x33FA3D0", VA = "0x1833FBDD0")]
		public static bool TryGetInstance(out PlayerState playerState)
		{
			return default(bool);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A71")]
		[Address(RVA = "0x33FBF00", Offset = "0x33FA500", VA = "0x1833FBF00")]
		public static PlayerState GetInstance()
		{
			return null;
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x0000C840 File Offset: 0x0000AA40
		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x33FBF40", Offset = "0x33FA540", VA = "0x1833FBF40")]
		public bool HasConsumed(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x33FC000", Offset = "0x33FA600", VA = "0x1833FC000")]
		public int GetConsumed(int itemId)
		{
			return 0;
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x33FC0B0", Offset = "0x33FA6B0", VA = "0x1833FC0B0")]
		public void IncConsumed(int itemId)
		{
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0000C870 File Offset: 0x0000AA70
		[Token(Token = "0x6002A75")]
		[Address(RVA = "0x33FC170", Offset = "0x33FA770", VA = "0x1833FC170")]
		public bool HasCrafted(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x6002A76")]
		[Address(RVA = "0x33FC230", Offset = "0x33FA830", VA = "0x1833FC230")]
		public int GetCrafted(int itemId)
		{
			return 0;
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x33FC2E0", Offset = "0x33FA8E0", VA = "0x1833FC2E0")]
		public void IncCrafted(int itemId)
		{
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A78")]
		[Address(RVA = "0x33FC3A0", Offset = "0x33FA9A0", VA = "0x1833FC3A0")]
		public NamedIntData GetNamedIntData(string namedIntData)
		{
			return null;
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A79")]
		[Address(RVA = "0x33FC450", Offset = "0x33FAA50", VA = "0x1833FC450")]
		public void SetNamedIntData(NamedIntData namedIntData)
		{
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x33FC5B0", Offset = "0x33FABB0", VA = "0x1833FC5B0")]
		public static NamedIntData GetOrCreate(string saveObjectNameId, int defaultValue)
		{
			return null;
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x33FC7A0", Offset = "0x33FADA0", VA = "0x1833FC7A0")]
		private static void SavedNamedIntData(NamedIntData obj)
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerState()
		{
		}

		// Token: 0x04002598 RID: 9624
		[Token(Token = "0x4002598")]
		private const string PlayerPositionKey = "player.position";

		// Token: 0x04002599 RID: 9625
		[Token(Token = "0x4002599")]
		private const string PlayerRotationKey = "player.rotation";

		// Token: 0x0400259A RID: 9626
		[Token(Token = "0x400259A")]
		private const string PlayerAreaMaskKey = "player.areaMask";

		// Token: 0x0400259B RID: 9627
		[Token(Token = "0x400259B")]
		private const string ConsumedKeyPrefix = "consumed.";

		// Token: 0x0400259C RID: 9628
		[Token(Token = "0x400259C")]
		private const string CraftedKeyPrefix = "crafted.";

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayerState _instance;

		// Token: 0x0400259E RID: 9630
		[Token(Token = "0x400259E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayerStateData _data;
	}
}
