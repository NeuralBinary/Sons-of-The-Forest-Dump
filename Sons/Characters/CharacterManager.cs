using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020006FD RID: 1789
	[Token(Token = "0x20006FD")]
	[AddComponentMenu("Sons/Characters/Character Manager")]
	public class CharacterManager : MonoBehaviour
	{
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F45 RID: 12101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065E")]
		public static CharacterManager Instance
		{
			[Token(Token = "0x6002F44")]
			[Address(RVA = "0x345C840", Offset = "0x345AE40", VA = "0x18345C840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F45")]
			[Address(RVA = "0x345C880", Offset = "0x345AE80", VA = "0x18345C880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F46")]
		[Address(RVA = "0x345C910", Offset = "0x345AF10", VA = "0x18345C910")]
		private void CleanupInstance()
		{
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6002F47")]
		[Address(RVA = "0x345CA50", Offset = "0x345B050", VA = "0x18345CA50")]
		private bool SetupInstance()
		{
			return default(bool);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F48")]
		[Address(RVA = "0x345CCC0", Offset = "0x345B2C0", VA = "0x18345CCC0")]
		private void Awake()
		{
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F49")]
		[Address(RVA = "0x345CD80", Offset = "0x345B380", VA = "0x18345CD80")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4A")]
		[Address(RVA = "0x345CF00", Offset = "0x345B500", VA = "0x18345CF00")]
		private void SetupDebugCommands()
		{
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		[Token(Token = "0x6002F4B")]
		[Address(RVA = "0x345CFB0", Offset = "0x345B5B0", VA = "0x18345CFB0")]
		public bool DebugCommandAddCharacter(string arguments)
		{
			return default(bool);
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4C")]
		[Address(RVA = "0x345CFC0", Offset = "0x345B5C0", VA = "0x18345CFC0")]
		private void TryGetFloat(string[] ids, int index, ref float value)
		{
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4D")]
		[Address(RVA = "0x345D090", Offset = "0x345B690", VA = "0x18345D090")]
		private void TryGetInt(string[] ids, int index, ref int value)
		{
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		[Token(Token = "0x6002F4E")]
		[Address(RVA = "0x345D190", Offset = "0x345B790", VA = "0x18345D190")]
		public bool DebugAddCharacter(string arguments, bool instantSpawn = false)
		{
			return default(bool);
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		[Token(Token = "0x6002F4F")]
		[Address(RVA = "0x345E130", Offset = "0x345C730", VA = "0x18345E130")]
		private bool TryGetCharacterVariation(string id, string variationId, int numSpawned, out CharacterVariation characterVariation)
		{
			return default(bool);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x345E300", Offset = "0x345C900", VA = "0x18345E300")]
		private CharacterDefinition GetDefinition(string id)
		{
			return null;
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F51")]
		[Address(RVA = "0x345E700", Offset = "0x345CD00", VA = "0x18345E700")]
		public CharacterManager()
		{
		}

		// Token: 0x040028F0 RID: 10480
		[Token(Token = "0x40028F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _addCharacterDistance;

		// Token: 0x040028F1 RID: 10481
		[Token(Token = "0x40028F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CharacterDefinition> _definitions;
	}
}
