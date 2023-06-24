using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[Serializable]
	public struct AnimationParameter : IEquatable<AnimationParameter>, IComparable<AnimationParameter>
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000F")]
		public string Name
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x17000010")]
		public AnimatorControllerParameterType ParameterType
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return (AnimatorControllerParameterType)0;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2D20C10", Offset = "0x2D1F210", VA = "0x182D20C10")]
		private AnimationParameter(string name, string path, DataType dataType, AnimatorControllerParameterType paramType, float defaultValue)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2D20D60", Offset = "0x2D1F360", VA = "0x182D20D60")]
		private AnimationParameter(string name, string path, DataType dataType, AnimatorControllerParameterType paramType, bool defaultValue)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2D20EB0", Offset = "0x2D1F4B0", VA = "0x182D20EB0")]
		private AnimationParameter(string name, string path, DataType dataType, AnimatorControllerParameterType paramType, int defaultValue)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2D21000", Offset = "0x2D1F600", VA = "0x182D21000", Slot = "4")]
		public bool Equals(AnimationParameter other)
		{
			return default(bool);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2D21040", Offset = "0x2D1F640", VA = "0x182D21040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2D210F0", Offset = "0x2D1F6F0", VA = "0x182D210F0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
		public readonly int GetNameToHash()
		{
			return 0;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2D21170", Offset = "0x2D1F770", VA = "0x182D21170", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2D21190", Offset = "0x2D1F790", VA = "0x182D21190", Slot = "5")]
		public int CompareTo(AnimationParameter other)
		{
			return 0;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2D21000", Offset = "0x2D1F600", VA = "0x182D21000")]
		public static bool operator ==(AnimationParameter a, AnimationParameter b)
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2D21300", Offset = "0x2D1F900", VA = "0x182D21300")]
		public static bool operator !=(AnimationParameter a, AnimationParameter b)
		{
			return default(bool);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
		public static explicit operator int(AnimationParameter parameter)
		{
			return 0;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetPath()
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
		public DataType GetDataType()
		{
			return DataType.Parameter;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2D21340", Offset = "0x2D1F940", VA = "0x182D21340")]
		public static string GetTag(int tagHash)
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2D21500", Offset = "0x2D1FB00", VA = "0x182D21500")]
		public static string GetState(int shortNameHash)
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2D216C0", Offset = "0x2D1FCC0", VA = "0x182D216C0")]
		public static IEnumerable GetDropdownList(ReadOnlyCollection<AnimationParameter> allParams)
		{
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2D21B20", Offset = "0x2D20120", VA = "0x182D21B20")]
		public static ReadOnlyCollection<AnimationParameter> GetAll()
		{
			return null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2D21B90", Offset = "0x2D20190", VA = "0x182D21B90")]
		public static ReadOnlyCollection<AnimationParameter> GetAllParameters()
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2D21C00", Offset = "0x2D20200", VA = "0x182D21C00")]
		public static ReadOnlyCollection<AnimationParameter> GetAllStates()
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2D21C70", Offset = "0x2D20270", VA = "0x182D21C70")]
		public static ReadOnlyCollection<AnimationParameter> GetAllLayers()
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2D21CE0", Offset = "0x2D202E0", VA = "0x182D21CE0")]
		public static ReadOnlyCollection<AnimationParameter> GetAllTags()
		{
			return null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2D21D50", Offset = "0x2D20350", VA = "0x182D21D50")]
		public static ReadOnlyCollection<AnimationParameter> GetAllStatesAndTags()
		{
			return null;
		}

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x0")]
		public static AnimationParameter Invalid;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private DataType _dataType;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private string _name;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _path;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _hash;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private AnimatorControllerParameterType _paramType;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _boolDefault;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _floatDefault;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _intDefault;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x30")]
		public static readonly AnimationParameter ParamFloat_Aim_Back;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x60")]
		public static readonly AnimationParameter ParamFloat_Aim_Down;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x90")]
		public static readonly AnimationParameter ParamFloat_Aim_Forward;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly AnimationParameter ParamFloat_Aim_Left;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly AnimationParameter ParamFloat_Aim_Right;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x120")]
		public static readonly AnimationParameter ParamFloat_Aim_Up;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x150")]
		public static readonly AnimationParameter ParamFloat_aimAtTarget;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x180")]
		public static readonly AnimationParameter ParamFloat_Angry;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x1B0")]
		public static readonly AnimationParameter ParamFloat_AngularSpeed;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x1E0")]
		public static readonly AnimationParameter ParamFloat_artifactWobble;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x210")]
		public static readonly AnimationParameter ParamFloat_axeBlend1;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x240")]
		public static readonly AnimationParameter ParamFloat_BaseIdleSpeedMultiplier;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x270")]
		public static readonly AnimationParameter ParamFloat_Blend;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x2A0")]
		public static readonly AnimationParameter ParamFloat_bowSpeed;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x2D0")]
		public static readonly AnimationParameter ParamFloat_breatheFloat;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x300")]
		public static readonly AnimationParameter ParamFloat_CameraShakeBlendFactor;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x330")]
		public static readonly AnimationParameter ParamFloat_CameraShakeFrequencyFactor;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x360")]
		public static readonly AnimationParameter ParamFloat_carryItemLength;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x390")]
		public static readonly AnimationParameter ParamFloat_carryItemThickness;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x3C0")]
		public static readonly AnimationParameter ParamFloat_chainSpeed;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x3F0")]
		public static readonly AnimationParameter ParamFloat_clientBlend;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x420")]
		public static readonly AnimationParameter ParamFloat_climbSpeed;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x450")]
		public static readonly AnimationParameter ParamFloat_coldFloat;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x480")]
		public static readonly AnimationParameter ParamFloat_connectFloat;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x4B0")]
		public static readonly AnimationParameter ParamFloat_crouch;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x4E0")]
		public static readonly AnimationParameter ParamFloat_CutPillarBlend;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x510")]
		public static readonly AnimationParameter ParamFloat_diggingBlendX;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x540")]
		public static readonly AnimationParameter ParamFloat_diggingBlendY;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x570")]
		public static readonly AnimationParameter ParamFloat_Direction;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x5A0")]
		public static readonly AnimationParameter ParamFloat_DirectionX;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x5D0")]
		public static readonly AnimationParameter ParamFloat_DirectionZ;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x600")]
		public static readonly AnimationParameter ParamFloat_Float;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x630")]
		public static readonly AnimationParameter ParamFloat_Forward;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x660")]
		public static readonly AnimationParameter ParamFloat_fuel;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x690")]
		public static readonly AnimationParameter ParamFloat_GliderLean;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x6C0")]
		public static readonly AnimationParameter ParamFloat_Gravity;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x6F0")]
		public static readonly AnimationParameter ParamFloat_groundHeight;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x720")]
		public static readonly AnimationParameter ParamFloat_HitWeight;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x750")]
		public static readonly AnimationParameter ParamFloat_HoldItemIdle;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x780")]
		public static readonly AnimationParameter ParamFloat_hSpeed;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x7B0")]
		public static readonly AnimationParameter ParamFloat_IdleBlend;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x7E0")]
		public static readonly AnimationParameter ParamFloat_IdleFloat;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x810")]
		public static readonly AnimationParameter ParamFloat_inWaterBlend;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x840")]
		public static readonly AnimationParameter ParamFloat_Jump;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x870")]
		public static readonly AnimationParameter ParamFloat_JumpLeg;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x8A0")]
		public static readonly AnimationParameter ParamFloat_keypadFloat;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x8D0")]
		public static readonly AnimationParameter ParamFloat_leftHand;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x900")]
		public static readonly AnimationParameter ParamFloat_levelingHeightNorm;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x930")]
		public static readonly AnimationParameter ParamFloat_LogSledTilt;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x960")]
		public static readonly AnimationParameter ParamFloat_LogSledTwist;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x990")]
		public static readonly AnimationParameter ParamFloat_logSlideSpeed;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x9C0")]
		public static readonly AnimationParameter ParamFloat_lookDownBlend;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x9F0")]
		public static readonly AnimationParameter ParamFloat_MotionAbsorbWeight;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0xA20")]
		public static readonly AnimationParameter ParamFloat_New_Float;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0xA50")]
		public static readonly AnimationParameter ParamFloat_NormalizedSpeed;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xA80")]
		public static readonly AnimationParameter ParamFloat_normCamX;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0xAB0")]
		public static readonly AnimationParameter ParamFloat_normCamY;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0xAE0")]
		public static readonly AnimationParameter ParamFloat_overallSpeed;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xB10")]
		public static readonly AnimationParameter ParamFloat_pedIdleBlend;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0xB40")]
		public static readonly AnimationParameter ParamFloat_pillarLength;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0xB70")]
		public static readonly AnimationParameter ParamFloat_PitchDirection;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0xBA0")]
		public static readonly AnimationParameter ParamFloat_playerAngle;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0xBD0")]
		public static readonly AnimationParameter ParamFloat_PlayerAngle;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0xC00")]
		public static readonly AnimationParameter ParamFloat_pullCraneSpeed;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xC30")]
		public static readonly AnimationParameter ParamFloat_RecipeProgress;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xC60")]
		public static readonly AnimationParameter ParamFloat_RideLeanForwardBack;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xC90")]
		public static readonly AnimationParameter ParamFloat_RideLeanRightLeft;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xCC0")]
		public static readonly AnimationParameter ParamFloat_RidingTorsoTwist;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xCF0")]
		public static readonly AnimationParameter ParamFloat_Right;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xD20")]
		public static readonly AnimationParameter ParamFloat_ScaredIdle;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0xD50")]
		public static readonly AnimationParameter ParamFloat_shellBlend;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0xD80")]
		public static readonly AnimationParameter ParamFloat_singleArmBlock;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xDB0")]
		public static readonly AnimationParameter ParamFloat_skinDamage1;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0xDE0")]
		public static readonly AnimationParameter ParamFloat_skinDamage2;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xE10")]
		public static readonly AnimationParameter ParamFloat_skinDamage3;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0xE40")]
		public static readonly AnimationParameter ParamFloat_skinDamage4;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xE70")]
		public static readonly AnimationParameter ParamFloat_Speed;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0xEA0")]
		public static readonly AnimationParameter ParamFloat_spineBlendX;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0xED0")]
		public static readonly AnimationParameter ParamFloat_spineClampFloat;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0xF00")]
		public static readonly AnimationParameter ParamFloat_SyncNormalizedTime;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0xF30")]
		public static readonly AnimationParameter ParamFloat_TargetDir;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0xF60")]
		public static readonly AnimationParameter ParamFloat_TargetDistance;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0xF90")]
		public static readonly AnimationParameter ParamFloat_TargetDistanceXZ;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0xFC0")]
		public static readonly AnimationParameter ParamFloat_TempAimFloat;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0xFF0")]
		public static readonly AnimationParameter ParamFloat_terrainAngle;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x1020")]
		public static readonly AnimationParameter ParamFloat_terrainSlope;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x1050")]
		public static readonly AnimationParameter ParamFloat_tiredFloat;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x1080")]
		public static readonly AnimationParameter ParamFloat_Tree0;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x10B0")]
		public static readonly AnimationParameter ParamFloat_Tree1;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x10E0")]
		public static readonly AnimationParameter ParamFloat_Tree2;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x1110")]
		public static readonly AnimationParameter ParamFloat_treeHeightBlend;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x1140")]
		public static readonly AnimationParameter ParamFloat_Turn;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x1170")]
		public static readonly AnimationParameter ParamFloat_TwoArmBlock;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x11A0")]
		public static readonly AnimationParameter ParamFloat_VRBlend;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x11D0")]
		public static readonly AnimationParameter ParamFloat_vSpeed;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x1200")]
		public static readonly AnimationParameter ParamFloat_waterHeight;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x1230")]
		public static readonly AnimationParameter ParamFloat_weaponClipBlend;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x1260")]
		public static readonly AnimationParameter ParamFloat_weaponHit;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x1290")]
		public static readonly AnimationParameter ParamFloat_X;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x12C0")]
		public static readonly AnimationParameter ParamFloat_Z;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x12F0")]
		public static readonly AnimationParameter ParamInt_AnimationState;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x1320")]
		public static readonly AnimationParameter ParamInt_artifactState;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x1350")]
		public static readonly AnimationParameter ParamInt_artifactStateMP;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x1380")]
		public static readonly AnimationParameter ParamInt_assembleItem;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x13B0")]
		public static readonly AnimationParameter ParamInt_attackType;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x13E0")]
		public static readonly AnimationParameter ParamInt_AttackType;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x1410")]
		public static readonly AnimationParameter ParamInt_Block;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x1440")]
		public static readonly AnimationParameter ParamInt_bookCloseInt;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x1470")]
		public static readonly AnimationParameter ParamInt_buildingChopType;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x14A0")]
		public static readonly AnimationParameter ParamInt_carryCount;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x14D0")]
		public static readonly AnimationParameter ParamInt_carryLogType;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x1500")]
		public static readonly AnimationParameter ParamInt_carrySmallType;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x1530")]
		public static readonly AnimationParameter ParamInt_ChestItemId;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x1560")]
		public static readonly AnimationParameter ParamInt_climbDirInt;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x1590")]
		public static readonly AnimationParameter ParamInt_climbTypeInt;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x15C0")]
		public static readonly AnimationParameter ParamInt_ComboTransition;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x15F0")]
		public static readonly AnimationParameter ParamInt_consumeItem;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x1620")]
		public static readonly AnimationParameter ParamInt_crossbowReloadState;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x1650")]
		public static readonly AnimationParameter ParamInt_cutSceneStage;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x1680")]
		public static readonly AnimationParameter ParamInt_cutSceneType;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x16B0")]
		public static readonly AnimationParameter ParamInt_DodgeAndCounter;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x16E0")]
		public static readonly AnimationParameter ParamInt_DodgeDir;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x1710")]
		public static readonly AnimationParameter ParamInt_DodgeType;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x1740")]
		public static readonly AnimationParameter ParamInt_dodgeType;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x1770")]
		public static readonly AnimationParameter ParamInt_EatType;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x17A0")]
		public static readonly AnimationParameter ParamInt_enterCaveInt;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x17D0")]
		public static readonly AnimationParameter ParamInt_EnterCaveType;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x1800")]
		public static readonly AnimationParameter ParamInt_ExitCaveType;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x1830")]
		public static readonly AnimationParameter ParamInt_EyeItemId;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x1860")]
		public static readonly AnimationParameter ParamInt_FeetItemId;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x1890")]
		public static readonly AnimationParameter ParamInt_FoodType;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x18C0")]
		public static readonly AnimationParameter ParamInt_hangingInt;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x18F0")]
		public static readonly AnimationParameter ParamInt_hitDir;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x1920")]
		public static readonly AnimationParameter ParamInt_HitDir;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x1950")]
		public static readonly AnimationParameter ParamInt_hitDirection;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x1980")]
		public static readonly AnimationParameter ParamInt_hitElectrocutedType;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x19B0")]
		public static readonly AnimationParameter ParamInt_HItElectrocutedType;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x19E0")]
		public static readonly AnimationParameter ParamInt_HitElectrocutedType;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x1A10")]
		public static readonly AnimationParameter ParamInt_HitElectrocuteType;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x1A40")]
		public static readonly AnimationParameter ParamInt_HitFire;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x1A70")]
		public static readonly AnimationParameter ParamInt_hitMeleeType;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x1AA0")]
		public static readonly AnimationParameter ParamInt_HitMeleeType;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x1AD0")]
		public static readonly AnimationParameter ParamInt_HitMolotovType;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x1B00")]
		public static readonly AnimationParameter ParamInt_HitVariation;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x1B30")]
		public static readonly AnimationParameter ParamInt_idleActionType;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x1B60")]
		public static readonly AnimationParameter ParamInt_IdleActionType;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x1B90")]
		public static readonly AnimationParameter ParamInt_idleActionVariation;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x1BC0")]
		public static readonly AnimationParameter ParamInt_idleVariationType;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x1BF0")]
		public static readonly AnimationParameter ParamInt_Int;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x1C20")]
		public static readonly AnimationParameter ParamInt_jumpType;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x1C50")]
		public static readonly AnimationParameter ParamInt_knockBackInt;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x1C80")]
		public static readonly AnimationParameter ParamInt_LeftHandHeldItemId;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x1CB0")]
		public static readonly AnimationParameter ParamInt_LookDir;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x1CE0")]
		public static readonly AnimationParameter ParamInt_negativeReactionType;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x1D10")]
		public static readonly AnimationParameter ParamInt_NoiseReactionType;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x1D40")]
		public static readonly AnimationParameter ParamInt_onLadderState;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x1D70")]
		public static readonly AnimationParameter ParamInt_placeElementType;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x1DA0")]
		public static readonly AnimationParameter ParamInt_positiveReactionType;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x1DD0")]
		public static readonly AnimationParameter ParamInt_randInt1;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x1E00")]
		public static readonly AnimationParameter ParamInt_RandomClipSelection;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x1E30")]
		public static readonly AnimationParameter ParamInt_RandomTransition;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x1E60")]
		public static readonly AnimationParameter ParamInt_reloadType;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x1E90")]
		public static readonly AnimationParameter ParamInt_reloadTypeInt;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x1EC0")]
		public static readonly AnimationParameter ParamInt_RightHandHeldItemId;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x1EF0")]
		public static readonly AnimationParameter ParamInt_SpawnBabyType;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x1F20")]
		public static readonly AnimationParameter ParamInt_StaggerLocation;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x1F50")]
		public static readonly AnimationParameter ParamInt_stepMoveType;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x1F80")]
		public static readonly AnimationParameter ParamInt_StepMoveType;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x1FB0")]
		public static readonly AnimationParameter ParamInt_tauntType;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x1FE0")]
		public static readonly AnimationParameter ParamInt_TauntType;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x2010")]
		public static readonly AnimationParameter ParamInt_TestParmA;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x2040")]
		public static readonly AnimationParameter ParamInt_treeChopType;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x2070")]
		public static readonly AnimationParameter ParamInt_turnLegInt;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x20A0")]
		public static readonly AnimationParameter ParamBool_AimHeldItem;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x20D0")]
		public static readonly AnimationParameter ParamBool_aimSlingBool;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x2100")]
		public static readonly AnimationParameter ParamBool_aimWeapon;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x2130")]
		public static readonly AnimationParameter ParamBool_AimWeaponB;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x2160")]
		public static readonly AnimationParameter ParamBool_Alerted;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x2190")]
		public static readonly AnimationParameter ParamBool_AllowLowerBodyEquipClothingAnimations;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x21C0")]
		public static readonly AnimationParameter ParamBool_AllowUpperBodyEquipClothingAnimations;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x21F0")]
		public static readonly AnimationParameter ParamBool_Angry;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x2220")]
		public static readonly AnimationParameter ParamBool_AngryFace;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x2250")]
		public static readonly AnimationParameter ParamBool_artifactHeld;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x2280")]
		public static readonly AnimationParameter ParamBool_attack;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x22B0")]
		public static readonly AnimationParameter ParamBool_Attack;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x22E0")]
		public static readonly AnimationParameter ParamBool_AttackFromTree;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x2310")]
		public static readonly AnimationParameter ParamBool_attackHeavyBool;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x2340")]
		public static readonly AnimationParameter ParamBool_attackHighBool;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x2370")]
		public static readonly AnimationParameter ParamBool_AttackImpact;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x23A0")]
		public static readonly AnimationParameter ParamBool_AttackWall;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x23D0")]
		public static readonly AnimationParameter ParamBool_AxeAttack;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x2400")]
		public static readonly AnimationParameter ParamBool_axeHeld;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x2430")]
		public static readonly AnimationParameter ParamBool_BackAway;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x2460")]
		public static readonly AnimationParameter ParamBool_BackAwayScared;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x2490")]
		public static readonly AnimationParameter ParamBool_BadGuyEscapeStart;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x24C0")]
		public static readonly AnimationParameter ParamBool_BadGuyIntro;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x24F0")]
		public static readonly AnimationParameter ParamBool_ballHeld;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x2520")]
		public static readonly AnimationParameter ParamBool_BashBody;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x2550")]
		public static readonly AnimationParameter ParamBool_batteryDead;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x2580")]
		public static readonly AnimationParameter ParamBool_Beckon;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x25B0")]
		public static readonly AnimationParameter ParamBool_begin;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x25E0")]
		public static readonly AnimationParameter ParamBool_beginCrash;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x2610")]
		public static readonly AnimationParameter ParamBool_BellyFlopAttack;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x2640")]
		public static readonly AnimationParameter ParamBool_bigTree;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x2670")]
		public static readonly AnimationParameter ParamBool_binocularsHeld;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x26A0")]
		public static readonly AnimationParameter ParamBool_birdResetBool;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x26D0")]
		public static readonly AnimationParameter ParamBool_Blink;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x2700")]
		public static readonly AnimationParameter ParamBool_Block;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x2730")]
		public static readonly AnimationParameter ParamBool_blockColdBool;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x2760")]
		public static readonly AnimationParameter ParamBool_BlockHit;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x2790")]
		public static readonly AnimationParameter ParamBool_BlockRange;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x27C0")]
		public static readonly AnimationParameter ParamBool_BlowUp;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x27F0")]
		public static readonly AnimationParameter ParamBool_bodyHeld;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x2820")]
		public static readonly AnimationParameter ParamBool_bookHeld;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x2850")]
		public static readonly AnimationParameter ParamBool_Bool;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x2880")]
		public static readonly AnimationParameter ParamBool_BossMutantIntroStart;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x28B0")]
		public static readonly AnimationParameter ParamBool_bowFireBool;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x28E0")]
		public static readonly AnimationParameter ParamBool_bowHeld;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x2910")]
		public static readonly AnimationParameter ParamBool_breakout;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x2940")]
		public static readonly AnimationParameter ParamBool_BuildFire;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x2970")]
		public static readonly AnimationParameter ParamBool_Burning;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x29A0")]
		public static readonly AnimationParameter ParamBool_camCorderHeld;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x29D0")]
		public static readonly AnimationParameter ParamBool_CancelAction;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x2A00")]
		public static readonly AnimationParameter ParamBool_cancelCheckArms;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x2A30")]
		public static readonly AnimationParameter ParamBool_cancelReload;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x2A60")]
		public static readonly AnimationParameter ParamBool_canReload;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x2A90")]
		public static readonly AnimationParameter ParamBool_Captured;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x2AC0")]
		public static readonly AnimationParameter ParamBool_CaseIsOpen;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x2AF0")]
		public static readonly AnimationParameter ParamBool_CatchBreath;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x2B20")]
		public static readonly AnimationParameter ParamBool_CatchFish;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x2B50")]
		public static readonly AnimationParameter ParamBool_chainSawHeld;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x2B80")]
		public static readonly AnimationParameter ParamBool_chargingBool;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x2BB0")]
		public static readonly AnimationParameter ParamBool_checkArms;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x2BE0")]
		public static readonly AnimationParameter ParamBool_CheckBody;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x2C10")]
		public static readonly AnimationParameter ParamBool_ChopperCreditsStart;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x2C40")]
		public static readonly AnimationParameter ParamBool_ChopperExitStart;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x2C70")]
		public static readonly AnimationParameter ParamBool_ChopperGroupLeaveStart;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x2CA0")]
		public static readonly AnimationParameter ParamBool_ChopperLeaveVirginiaMissing;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x2CD0")]
		public static readonly AnimationParameter ParamBool_ChopperPlayerLeaveStart;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x2D00")]
		public static readonly AnimationParameter ParamBool_ChopperRobbyLeaveStart;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x2D30")]
		public static readonly AnimationParameter ParamBool_ChopperVirginiaLeaveStart;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x2D60")]
		public static readonly AnimationParameter ParamBool_CircleLeft;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x2D90")]
		public static readonly AnimationParameter ParamBool_CircleRight;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x2DC0")]
		public static readonly AnimationParameter ParamBool_clampSpine;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x2DF0")]
		public static readonly AnimationParameter ParamBool_Clapping;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x2E20")]
		public static readonly AnimationParameter ParamBool_ClearBrush;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x2E50")]
		public static readonly AnimationParameter ParamBool_ClearTarp;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x2E80")]
		public static readonly AnimationParameter ParamBool_client;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x2EB0")]
		public static readonly AnimationParameter ParamBool_Climb;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x2EE0")]
		public static readonly AnimationParameter ParamBool_ClimbIntoWindow;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x2F10")]
		public static readonly AnimationParameter ParamBool_ClimbPlatform;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x2F40")]
		public static readonly AnimationParameter ParamBool_ClimbWall;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x2F70")]
		public static readonly AnimationParameter ParamBool_close;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x2FA0")]
		public static readonly AnimationParameter ParamBool_closeCamCorder;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x2FD0")]
		public static readonly AnimationParameter ParamBool_ClosedEyes;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x3000")]
		public static readonly AnimationParameter ParamBool_Cold;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x3030")]
		public static readonly AnimationParameter ParamBool_ComboAttack;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x3060")]
		public static readonly AnimationParameter ParamBool_comboBool;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x3090")]
		public static readonly AnimationParameter ParamBool_ComboEnder;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x30C0")]
		public static readonly AnimationParameter ParamBool_continue;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x30F0")]
		public static readonly AnimationParameter ParamBool_couchBool;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x3120")]
		public static readonly AnimationParameter ParamBool_Cower;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x3150")]
		public static readonly AnimationParameter ParamBool_CraftingCogRotate;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x3180")]
		public static readonly AnimationParameter ParamBool_craneAttach;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x31B0")]
		public static readonly AnimationParameter ParamBool_crashBegin;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x31E0")]
		public static readonly AnimationParameter ParamBool_crashStop;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x3210")]
		public static readonly AnimationParameter ParamBool_CrawlBack;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x3240")]
		public static readonly AnimationParameter ParamBool_CrawlUnderWall;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x3270")]
		public static readonly AnimationParameter ParamBool_crossbowHeld;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x32A0")]
		public static readonly AnimationParameter ParamBool_crossbowReload;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x32D0")]
		public static readonly AnimationParameter ParamBool_Crouch;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x3300")]
		public static readonly AnimationParameter ParamBool_crouchIdle;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x3330")]
		public static readonly AnimationParameter ParamBool_CutWindow;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x3360")]
		public static readonly AnimationParameter ParamBool_DanceRadio;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x3390")]
		public static readonly AnimationParameter ParamBool_DanceToMusic;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x33C0")]
		public static readonly AnimationParameter ParamBool_DanceTree;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x33F0")]
		public static readonly AnimationParameter ParamBool_Dead;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x3420")]
		public static readonly AnimationParameter ParamBool_deadBool1;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x3450")]
		public static readonly AnimationParameter ParamBool_Death;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x3480")]
		public static readonly AnimationParameter ParamBool_death;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x34B0")]
		public static readonly AnimationParameter ParamBool_deathBool;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x34E0")]
		public static readonly AnimationParameter ParamBool_deathFromInjuredBool;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x3510")]
		public static readonly AnimationParameter ParamBool_DemonBossDead;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x3540")]
		public static readonly AnimationParameter ParamBool_DemonBossIntro;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x3570")]
		public static readonly AnimationParameter ParamBool_DemonBossIntroStart;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x35A0")]
		public static readonly AnimationParameter ParamBool_DemonBossLoop;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x35D0")]
		public static readonly AnimationParameter ParamBool_DenyEntry;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x3600")]
		public static readonly AnimationParameter ParamBool_DigBlocked;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x3630")]
		public static readonly AnimationParameter ParamBool_DigEmpty;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x3660")]
		public static readonly AnimationParameter ParamBool_DismemberLeftArm;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x3690")]
		public static readonly AnimationParameter ParamBool_DismemberLeftLeg;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x36C0")]
		public static readonly AnimationParameter ParamBool_DismemberRightArm;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x36F0")]
		public static readonly AnimationParameter ParamBool_DismemberRightLeg;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x3720")]
		public static readonly AnimationParameter ParamBool_DismountLadder;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x3750")]
		public static readonly AnimationParameter ParamBool_DistantYell;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x3780")]
		public static readonly AnimationParameter ParamBool_doAttackHeavyBool;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x37B0")]
		public static readonly AnimationParameter ParamBool_Dodge;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x37E0")]
		public static readonly AnimationParameter ParamBool_DoorKnock;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x3810")]
		public static readonly AnimationParameter ParamBool_doPlaceLog;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x3840")]
		public static readonly AnimationParameter ParamBool_DragAlly;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x3870")]
		public static readonly AnimationParameter ParamBool_dragAwayBool;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x38A0")]
		public static readonly AnimationParameter ParamBool_DraggedAlly;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x38D0")]
		public static readonly AnimationParameter ParamBool_DragLog;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x3900")]
		public static readonly AnimationParameter ParamBool_drawBool;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x3930")]
		public static readonly AnimationParameter ParamBool_drawBowBool;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x3960")]
		public static readonly AnimationParameter ParamBool_Drink;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x3990")]
		public static readonly AnimationParameter ParamBool_DrinkBlood;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x39C0")]
		public static readonly AnimationParameter ParamBool_DrinkBloodStanding;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x39F0")]
		public static readonly AnimationParameter ParamBool_DrinkWater;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x3A20")]
		public static readonly AnimationParameter ParamBool_drinkWater;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x3A50")]
		public static readonly AnimationParameter ParamBool_DrivingGolfCart;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x3A80")]
		public static readonly AnimationParameter ParamBool_DrivingLogSled;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x3AB0")]
		public static readonly AnimationParameter ParamBool_DropFromCeiling;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x3AE0")]
		public static readonly AnimationParameter ParamBool_DropHelicopter;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x3B10")]
		public static readonly AnimationParameter ParamBool_Drowning;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x3B40")]
		public static readonly AnimationParameter ParamBool_Dying;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x3B70")]
		public static readonly AnimationParameter ParamBool_EatFood;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x3BA0")]
		public static readonly AnimationParameter ParamBool_eatMeat;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x3BD0")]
		public static readonly AnimationParameter ParamBool_Electrocuted;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x3C00")]
		public static readonly AnimationParameter ParamBool_empty;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x3C30")]
		public static readonly AnimationParameter ParamBool_EmptyItem;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x3C60")]
		public static readonly AnimationParameter ParamBool_EmptyWeapon;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x3C90")]
		public static readonly AnimationParameter ParamBool_Engine;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x3CC0")]
		public static readonly AnimationParameter ParamBool_EnterHatch;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x3CF0")]
		public static readonly AnimationParameter ParamBool_ExamineBody;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x3D20")]
		public static readonly AnimationParameter ParamBool_exitClimbTopBool;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x3D50")]
		public static readonly AnimationParameter ParamBool_ExitHatch;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x3D80")]
		public static readonly AnimationParameter ParamBool_ExitHatchB;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x3DB0")]
		public static readonly AnimationParameter ParamBool_fall;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x3DE0")]
		public static readonly AnimationParameter ParamBool_Falling;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x3E10")]
		public static readonly AnimationParameter ParamBool_fastCloseBook;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x3E40")]
		public static readonly AnimationParameter ParamBool_FastTurn;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x3E70")]
		public static readonly AnimationParameter ParamBool_FatalHit;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x3EA0")]
		public static readonly AnimationParameter ParamBool_Female;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x3ED0")]
		public static readonly AnimationParameter ParamBool_fillPotBool;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x3F00")]
		public static readonly AnimationParameter ParamBool_FinalDeath;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x3F30")]
		public static readonly AnimationParameter ParamBool_fire;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x3F60")]
		public static readonly AnimationParameter ParamBool_Fire;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x3F90")]
		public static readonly AnimationParameter ParamBool_fireWeapon;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x3FC0")]
		public static readonly AnimationParameter ParamBool_FireWeaponB;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x3FF0")]
		public static readonly AnimationParameter ParamBool_FirstDance;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x4020")]
		public static readonly AnimationParameter ParamBool_firstDeath;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x4050")]
		public static readonly AnimationParameter ParamBool_firstInteraction;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x4080")]
		public static readonly AnimationParameter ParamBool_FirstTimeEquipChest;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x40B0")]
		public static readonly AnimationParameter ParamBool_FirstTimeEquipFeet;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x40E0")]
		public static readonly AnimationParameter ParamBool_FirstTimeEquipLeftHand;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x4110")]
		public static readonly AnimationParameter ParamBool_firstTimePickup;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x4140")]
		public static readonly AnimationParameter ParamBool_firstTimeTrackerEquip;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x4170")]
		public static readonly AnimationParameter ParamBool_flameAttack;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x41A0")]
		public static readonly AnimationParameter ParamBool_flameThrowerHeld;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x41D0")]
		public static readonly AnimationParameter ParamBool_flaregunHeld;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x4200")]
		public static readonly AnimationParameter ParamBool_flareHeld;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x4230")]
		public static readonly AnimationParameter ParamBool_flashLightHeld;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x4260")]
		public static readonly AnimationParameter ParamBool_flintLockHeld;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x4290")]
		public static readonly AnimationParameter ParamBool_flipPageBack;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x42C0")]
		public static readonly AnimationParameter ParamBool_flipPageForward;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x42F0")]
		public static readonly AnimationParameter ParamBool_Fly;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x4320")]
		public static readonly AnimationParameter ParamBool_flyBack;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x4350")]
		public static readonly AnimationParameter ParamBool_forceReload;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x4380")]
		public static readonly AnimationParameter ParamBool_frontSeats;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x43B0")]
		public static readonly AnimationParameter ParamBool_Gather;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x43E0")]
		public static readonly AnimationParameter ParamBool_gearUpEquip;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x4410")]
		public static readonly AnimationParameter ParamBool_genericHeld;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x4440")]
		public static readonly AnimationParameter ParamBool_genericHoldPouch;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x4470")]
		public static readonly AnimationParameter ParamBool_genericWideHeld;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x44A0")]
		public static readonly AnimationParameter ParamBool_GetDownSonStart;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x44D0")]
		public static readonly AnimationParameter ParamBool_GetDownSonWakeupStart;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x4500")]
		public static readonly AnimationParameter ParamBool_GetToTheChopperStart;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x4530")]
		public static readonly AnimationParameter ParamBool_ghostMode;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x4560")]
		public static readonly AnimationParameter ParamBool_girlPickup;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x4590")]
		public static readonly AnimationParameter ParamBool_girlTransform;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x45C0")]
		public static readonly AnimationParameter ParamBool_Glide;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x45F0")]
		public static readonly AnimationParameter ParamBool_GliderOpenWings;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x4620")]
		public static readonly AnimationParameter ParamBool_GlidingInAir;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x4650")]
		public static readonly AnimationParameter ParamBool_GoldDoorStart;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x4680")]
		public static readonly AnimationParameter ParamBool_GoldRoomStart;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x46B0")]
		public static readonly AnimationParameter ParamBool_GoldRoomVirginiaMissing;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x46E0")]
		public static readonly AnimationParameter ParamBool_goodbyeTimmy;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x4710")]
		public static readonly AnimationParameter ParamBool_goToRelax;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x4740")]
		public static readonly AnimationParameter ParamBool_Grabbed;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x4770")]
		public static readonly AnimationParameter ParamBool_GrabFish;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x47A0")]
		public static readonly AnimationParameter ParamBool_GrenadeHeld;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x47D0")]
		public static readonly AnimationParameter ParamBool_groundAxeChopBool;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x4800")]
		public static readonly AnimationParameter ParamBool_gunAttack;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x4830")]
		public static readonly AnimationParameter ParamBool_hangGliderFlying;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x4860")]
		public static readonly AnimationParameter ParamBool_hangGliderHeld;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x4890")]
		public static readonly AnimationParameter ParamBool_hangingBool;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x48C0")]
		public static readonly AnimationParameter ParamBool_HeadDown;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x48F0")]
		public static readonly AnimationParameter ParamBool_HelicopterHeld;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x4920")]
		public static readonly AnimationParameter ParamBool_Hide;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x4950")]
		public static readonly AnimationParameter ParamBool_HideInLeaves;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x4980")]
		public static readonly AnimationParameter ParamBool_HitAdditive;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x49B0")]
		public static readonly AnimationParameter ParamBool_HitArm;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x49E0")]
		public static readonly AnimationParameter ParamBool_HitBackBody;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x4A10")]
		public static readonly AnimationParameter ParamBool_HitBody;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x4A40")]
		public static readonly AnimationParameter ParamBool_HitElectrocute;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x4A70")]
		public static readonly AnimationParameter ParamBool_HitElectrocuted;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x4AA0")]
		public static readonly AnimationParameter ParamBool_HitExplosion;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x4AD0")]
		public static readonly AnimationParameter ParamBool_HitFallDown;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x4B00")]
		public static readonly AnimationParameter ParamBool_hitFallDown;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x4B30")]
		public static readonly AnimationParameter ParamBool_HitFallOffTree;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x4B60")]
		public static readonly AnimationParameter ParamBool_HitFrontBody;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x4B90")]
		public static readonly AnimationParameter ParamBool_hitGround;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x4BC0")]
		public static readonly AnimationParameter ParamBool_hitHead;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x4BF0")]
		public static readonly AnimationParameter ParamBool_HitHead;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x4C20")]
		public static readonly AnimationParameter ParamBool_HitKnockdown;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x4C50")]
		public static readonly AnimationParameter ParamBool_HitKnockDown;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x4C80")]
		public static readonly AnimationParameter ParamBool_hitLeg;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x4CB0")]
		public static readonly AnimationParameter ParamBool_HitLeg;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x4CE0")]
		public static readonly AnimationParameter ParamBool_HitMelee;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x4D10")]
		public static readonly AnimationParameter ParamBool_hitMelee;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x4D40")]
		public static readonly AnimationParameter ParamBool_HitProjectile;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x4D70")]
		public static readonly AnimationParameter ParamBool_HitShotgun;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x4DA0")]
		public static readonly AnimationParameter ParamBool_HitStagger;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x4DD0")]
		public static readonly AnimationParameter ParamBool_HitStomach;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x4E00")]
		public static readonly AnimationParameter ParamBool_hitStomach;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x4E30")]
		public static readonly AnimationParameter ParamBool_HitTreeFall;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x4E60")]
		public static readonly AnimationParameter ParamBool_HoldPistol;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x4E90")]
		public static readonly AnimationParameter ParamBool_HoldRangedWeapon;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x4EC0")]
		public static readonly AnimationParameter ParamBool_HoldShotgun;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x4EF0")]
		public static readonly AnimationParameter ParamBool_Hover;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x4F20")]
		public static readonly AnimationParameter ParamBool_Hug;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x4F50")]
		public static readonly AnimationParameter ParamBool_idleAction;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x4F80")]
		public static readonly AnimationParameter ParamBool_IdleDart;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x4FB0")]
		public static readonly AnimationParameter ParamBool_IdleFidget;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x4FE0")]
		public static readonly AnimationParameter ParamBool_IdleLook;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x5010")]
		public static readonly AnimationParameter ParamBool_InCombat;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x5040")]
		public static readonly AnimationParameter ParamBool_injured;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x5070")]
		public static readonly AnimationParameter ParamBool_injuredBool;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x50A0")]
		public static readonly AnimationParameter ParamBool_InjuredSit;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x50D0")]
		public static readonly AnimationParameter ParamBool_InMidAir;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x5100")]
		public static readonly AnimationParameter ParamBool_InShell;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x5130")]
		public static readonly AnimationParameter ParamBool_introStandBool;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x5160")]
		public static readonly AnimationParameter ParamBool_InventoryInteract;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x5190")]
		public static readonly AnimationParameter ParamBool_InventoryInWardrobeView;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x51C0")]
		public static readonly AnimationParameter ParamBool_InvestigateBush;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x51F0")]
		public static readonly AnimationParameter ParamBool_InWater;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x5220")]
		public static readonly AnimationParameter ParamBool_IsActive;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x5250")]
		public static readonly AnimationParameter ParamBool_IsAttacking;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x5280")]
		public static readonly AnimationParameter ParamBool_IsBlocked;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x52B0")]
		public static readonly AnimationParameter ParamBool_IsMoving;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x52E0")]
		public static readonly AnimationParameter ParamBool_IsStrafing;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x5310")]
		public static readonly AnimationParameter ParamBool_itemHeld;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x5340")]
		public static readonly AnimationParameter ParamBool_JumpAttack;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x5370")]
		public static readonly AnimationParameter ParamBool_jumpAttack;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x53A0")]
		public static readonly AnimationParameter ParamBool_jumpBool;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x53D0")]
		public static readonly AnimationParameter ParamBool_JumpOffEdge;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x5400")]
		public static readonly AnimationParameter ParamBool_JumpOffRockAttack;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x5430")]
		public static readonly AnimationParameter ParamBool_JumpOffRockBack;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x5460")]
		public static readonly AnimationParameter ParamBool_JumpOffRockFront;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x5490")]
		public static readonly AnimationParameter ParamBool_JumpOffTree;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x54C0")]
		public static readonly AnimationParameter ParamBool_JumpOntoRock;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x54F0")]
		public static readonly AnimationParameter ParamBool_JumpOntoTree;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x5520")]
		public static readonly AnimationParameter ParamBool_JumpOutOfLeaves;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x5550")]
		public static readonly AnimationParameter ParamBool_JumpOverBig;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x5580")]
		public static readonly AnimationParameter ParamBool_JumpOverSmall;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x55B0")]
		public static readonly AnimationParameter ParamBool_JumpToCeiling;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x55E0")]
		public static readonly AnimationParameter ParamBool_JumpTreeToTree;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x5610")]
		public static readonly AnimationParameter ParamBool_JumpUpBig;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x5640")]
		public static readonly AnimationParameter ParamBool_JumpUpMedium;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x5670")]
		public static readonly AnimationParameter ParamBool_JumpUpSmall;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x56A0")]
		public static readonly AnimationParameter ParamBool_kick;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x56D0")]
		public static readonly AnimationParameter ParamBool_KickAttack;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x5700")]
		public static readonly AnimationParameter ParamBool_KickBody;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x5730")]
		public static readonly AnimationParameter ParamBool_Landed;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x5760")]
		public static readonly AnimationParameter ParamBool_laserHeld;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x5790")]
		public static readonly AnimationParameter ParamBool_Laugh;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x57C0")]
		public static readonly AnimationParameter ParamBool_LayEggs;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x57F0")]
		public static readonly AnimationParameter ParamBool_leanForward;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x5820")]
		public static readonly AnimationParameter ParamBool_leftLightWeaponBool;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x5850")]
		public static readonly AnimationParameter ParamBool_leftOpen;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x5880")]
		public static readonly AnimationParameter ParamBool_lighterHeld;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x58B0")]
		public static readonly AnimationParameter ParamBool_lighterIgnite;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x58E0")]
		public static readonly AnimationParameter ParamBool_LightFire;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x5910")]
		public static readonly AnimationParameter ParamBool_lightFirePrompt;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x5940")]
		public static readonly AnimationParameter ParamBool_lightWeaponBool;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x5970")]
		public static readonly AnimationParameter ParamBool_Limping;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x59A0")]
		public static readonly AnimationParameter ParamBool_load;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x59D0")]
		public static readonly AnimationParameter ParamBool_logHeld;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x5A00")]
		public static readonly AnimationParameter ParamBool_LookAround;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x5A30")]
		public static readonly AnimationParameter ParamBool_lookAtItem;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x5A60")]
		public static readonly AnimationParameter ParamBool_lookAtItemRight;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x5A90")]
		public static readonly AnimationParameter ParamBool_lookAtPhoto;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x5AC0")]
		public static readonly AnimationParameter ParamBool_LoudNoise;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x5AF0")]
		public static readonly AnimationParameter ParamBool_LungeAttack;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x5B20")]
		public static readonly AnimationParameter ParamBool_MakeNest;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x5B50")]
		public static readonly AnimationParameter ParamBool_mapHeld;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x5B80")]
		public static readonly AnimationParameter ParamBool_maskHeld;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x5BB0")]
		public static readonly AnimationParameter ParamBool_molotovHeld;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x5BE0")]
		public static readonly AnimationParameter ParamBool_MournBody;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x5C10")]
		public static readonly AnimationParameter ParamBool_mourningBool1;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x5C40")]
		public static readonly AnimationParameter ParamBool_movingBool;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x5C70")]
		public static readonly AnimationParameter ParamBool_net;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x5CA0")]
		public static readonly AnimationParameter ParamBool_NeutralSpinePitch;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x5CD0")]
		public static readonly AnimationParameter ParamBool_nextHit;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x5D00")]
		public static readonly AnimationParameter ParamBool_noAmmo;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x5D30")]
		public static readonly AnimationParameter ParamBool_noBattery;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x5D60")]
		public static readonly AnimationParameter ParamBool_Nudge;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x5D90")]
		public static readonly AnimationParameter ParamBool_oculusDemoBool;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x5DC0")]
		public static readonly AnimationParameter ParamBool_OnGround;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x5DF0")]
		public static readonly AnimationParameter ParamBool_onHand;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x5E20")]
		public static readonly AnimationParameter ParamBool_OnHit;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x5E50")]
		public static readonly AnimationParameter ParamBool_open;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x5E80")]
		public static readonly AnimationParameter ParamBool_OpenHatch;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x5EB0")]
		public static readonly AnimationParameter ParamBool_OpenHatchNoWipe;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x5EE0")]
		public static readonly AnimationParameter ParamBool_OpenHellDoor;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x5F10")]
		public static readonly AnimationParameter ParamBool_openKeypadDoor;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x5F40")]
		public static readonly AnimationParameter ParamBool_OpenSecurityDoor;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x5F70")]
		public static readonly AnimationParameter ParamBool_operatePanel;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x5FA0")]
		public static readonly AnimationParameter ParamBool_operatePanelExit;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x5FD0")]
		public static readonly AnimationParameter ParamBool_p1;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x6000")]
		public static readonly AnimationParameter ParamBool_p2;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x6030")]
		public static readonly AnimationParameter ParamBool_p3;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x6060")]
		public static readonly AnimationParameter ParamBool_p4FlyBack;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x6090")]
		public static readonly AnimationParameter ParamBool_paddleBool;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x60C0")]
		public static readonly AnimationParameter ParamBool_paddleIdleBool;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x60F0")]
		public static readonly AnimationParameter ParamBool_padGiveNote;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x6120")]
		public static readonly AnimationParameter ParamBool_padGiveOrder;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x6150")]
		public static readonly AnimationParameter ParamBool_padLower;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x6180")]
		public static readonly AnimationParameter ParamBool_padRaise;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x61B0")]
		public static readonly AnimationParameter ParamBool_Parried;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x61E0")]
		public static readonly AnimationParameter ParamBool_parryBool;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x6210")]
		public static readonly AnimationParameter ParamBool_PassengerGolfCart;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x6240")]
		public static readonly AnimationParameter ParamBool_pedHeld;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x6270")]
		public static readonly AnimationParameter ParamBool_PeekAround;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x62A0")]
		public static readonly AnimationParameter ParamBool_PickupAndThrowBody;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x62D0")]
		public static readonly AnimationParameter ParamBool_PickUpBag;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x6300")]
		public static readonly AnimationParameter ParamBool_PickupHelicopter;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x6330")]
		public static readonly AnimationParameter ParamBool_pickupTimmy;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x6360")]
		public static readonly AnimationParameter ParamBool_pistolHeld;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x6390")]
		public static readonly AnimationParameter ParamBool_PlacePillar;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x63C0")]
		public static readonly AnimationParameter ParamBool_PlaceStake;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x63F0")]
		public static readonly AnimationParameter ParamBool_PlaceTarp;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x6420")]
		public static readonly AnimationParameter ParamBool_PointAtEnemies;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x6450")]
		public static readonly AnimationParameter ParamBool_pointAtMap;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x6480")]
		public static readonly AnimationParameter ParamBool_PointAtObject;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x64B0")]
		public static readonly AnimationParameter ParamBool_potHeld;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x64E0")]
		public static readonly AnimationParameter ParamBool_Pray;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x6510")]
		public static readonly AnimationParameter ParamBool_ProneBack;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x6540")]
		public static readonly AnimationParameter ParamBool_ProneStomach;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x6570")]
		public static readonly AnimationParameter ParamBool_Pulse;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x65A0")]
		public static readonly AnimationParameter ParamBool_PushDoor;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x65D0")]
		public static readonly AnimationParameter ParamBool_pushSledBool;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x6600")]
		public static readonly AnimationParameter ParamBool_reactBool1;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x6630")]
		public static readonly AnimationParameter ParamBool_RefillWaterContainer;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x6660")]
		public static readonly AnimationParameter ParamBool_RefuseOrder;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x6690")]
		public static readonly AnimationParameter ParamBool_release;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x66C0")]
		public static readonly AnimationParameter ParamBool_releaseThrowerBool;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x66F0")]
		public static readonly AnimationParameter ParamBool_reload;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x6720")]
		public static readonly AnimationParameter ParamBool_ReloadHeldItem;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x6750")]
		public static readonly AnimationParameter ParamBool_repairHammerHeld;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x6780")]
		public static readonly AnimationParameter ParamBool_Reset;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x67B0")]
		public static readonly AnimationParameter ParamBool_resetBook;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x67E0")]
		public static readonly AnimationParameter ParamBool_resetClimbBool;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x6810")]
		public static readonly AnimationParameter ParamBool_ResetTrap;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x6840")]
		public static readonly AnimationParameter ParamBool_Rest;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x6870")]
		public static readonly AnimationParameter ParamBool_RifleHeld;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x68A0")]
		public static readonly AnimationParameter ParamBool_rockHeld;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x68D0")]
		public static readonly AnimationParameter ParamBool_RubFeet;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x6900")]
		public static readonly AnimationParameter ParamBool_RunAttack;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x6930")]
		public static readonly AnimationParameter ParamBool_sapHeld;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x6960")]
		public static readonly AnimationParameter ParamBool_sawAttack;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x6990")]
		public static readonly AnimationParameter ParamBool_Scared;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x69C0")]
		public static readonly AnimationParameter ParamBool_ScaredFace;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x69F0")]
		public static readonly AnimationParameter ParamBool_Scream;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x6A20")]
		public static readonly AnimationParameter ParamBool_setClimbBool;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x6A50")]
		public static readonly AnimationParameter ParamBool_setThrowerBool;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x6A80")]
		public static readonly AnimationParameter ParamBool_SetTimeBombTimer;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x6AB0")]
		public static readonly AnimationParameter ParamBool_ShakeHead;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x6AE0")]
		public static readonly AnimationParameter ParamBool_shellHeld;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x6B10")]
		public static readonly AnimationParameter ParamBool_shellRideBool;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x6B40")]
		public static readonly AnimationParameter ParamBool_shotgunHeld;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x6B70")]
		public static readonly AnimationParameter ParamBool_ShovelDig;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x6BA0")]
		public static readonly AnimationParameter ParamBool_ShovelDigLine;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x6BD0")]
		public static readonly AnimationParameter ParamBool_shovelHeld;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x6C00")]
		public static readonly AnimationParameter ParamBool_Sit;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x6C30")]
		public static readonly AnimationParameter ParamBool_SitChair;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x6C60")]
		public static readonly AnimationParameter ParamBool_SitInWater;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x6C90")]
		public static readonly AnimationParameter ParamBool_sittingBool;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x6CC0")]
		public static readonly AnimationParameter ParamBool_skinAnimal;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x6CF0")]
		public static readonly AnimationParameter ParamBool_SlapFightA;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x6D20")]
		public static readonly AnimationParameter ParamBool_SlapFightB;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x6D50")]
		public static readonly AnimationParameter ParamBool_SlapFightFinished;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x6D80")]
		public static readonly AnimationParameter ParamBool_SlapFightVictory;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x6DB0")]
		public static readonly AnimationParameter ParamBool_SlapFightVictoryB;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x6DE0")]
		public static readonly AnimationParameter ParamBool_Sleep;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x6E10")]
		public static readonly AnimationParameter ParamBool_SleepBed;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x6E40")]
		public static readonly AnimationParameter ParamBool_SlideDown;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x6E70")]
		public static readonly AnimationParameter ParamBool_SlideDownOff;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x6EA0")]
		public static readonly AnimationParameter ParamBool_SlideDownOn;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x6ED0")]
		public static readonly AnimationParameter ParamBool_SlideOut;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x6F00")]
		public static readonly AnimationParameter ParamBool_slingShotHeld;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x6F30")]
		public static readonly AnimationParameter ParamBool_SlingshotHeld;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x6F60")]
		public static readonly AnimationParameter ParamBool_Slip;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x6F90")]
		public static readonly AnimationParameter ParamBool_smallAxe;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x6FC0")]
		public static readonly AnimationParameter ParamBool_SmallBodyOnTop;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x6FF0")]
		public static readonly AnimationParameter ParamBool_SmallRockHeld;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x7020")]
		public static readonly AnimationParameter ParamBool_smallTree;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x7050")]
		public static readonly AnimationParameter ParamBool_smashBool;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x7080")]
		public static readonly AnimationParameter ParamBool_SpawnBaby;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x70B0")]
		public static readonly AnimationParameter ParamBool_SpawnTwins;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x70E0")]
		public static readonly AnimationParameter ParamBool_spearHeld;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x7110")]
		public static readonly AnimationParameter ParamBool_spearRaiseBool;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x7140")]
		public static readonly AnimationParameter ParamBool_spearThrowBool;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x7170")]
		public static readonly AnimationParameter ParamBool_StartBlock;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x71A0")]
		public static readonly AnimationParameter ParamBool_startCrash;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x71D0")]
		public static readonly AnimationParameter ParamBool_StepBack;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x7200")]
		public static readonly AnimationParameter ParamBool_StepCurious;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x7230")]
		public static readonly AnimationParameter ParamBool_StepCuriousBack;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x7260")]
		public static readonly AnimationParameter ParamBool_stickAttack;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x7290")]
		public static readonly AnimationParameter ParamBool_stickBlock;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x72C0")]
		public static readonly AnimationParameter ParamBool_stickHeld;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x72F0")]
		public static readonly AnimationParameter ParamBool_stickShove;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x7320")]
		public static readonly AnimationParameter ParamBool_Strafe;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x7350")]
		public static readonly AnimationParameter ParamBool_strikeFlare;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x7380")]
		public static readonly AnimationParameter ParamBool_StructureElementHeld;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x73B0")]
		public static readonly AnimationParameter ParamBool_Struggle;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x73E0")]
		public static readonly AnimationParameter ParamBool_StuckSlugIsAgitated;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x7410")]
		public static readonly AnimationParameter ParamBool_stunGunHeld;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x7440")]
		public static readonly AnimationParameter ParamBool_Stunned;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x7470")]
		public static readonly AnimationParameter ParamBool_Swim;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x74A0")]
		public static readonly AnimationParameter ParamBool_swimDiveBool;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x74D0")]
		public static readonly AnimationParameter ParamBool_swimmingBool;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x7500")]
		public static readonly AnimationParameter ParamBool_SwoopAttack;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x7530")]
		public static readonly AnimationParameter ParamBool_SyncMournBody;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x7560")]
		public static readonly AnimationParameter ParamBool_TargetLow;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x7590")]
		public static readonly AnimationParameter ParamBool_TaserStickHeld;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x75C0")]
		public static readonly AnimationParameter ParamBool_Taunt;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x75F0")]
		public static readonly AnimationParameter ParamBool_taunt;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x7620")]
		public static readonly AnimationParameter ParamBool_TauntDance;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x7650")]
		public static readonly AnimationParameter ParamBool_TauntFromTree;

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x7680")]
		public static readonly AnimationParameter ParamBool_TauntFullbody;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x76B0")]
		public static readonly AnimationParameter ParamBool_ThrowRock;

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x76E0")]
		public static readonly AnimationParameter ParamBool_ThumbsUp;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x7710")]
		public static readonly AnimationParameter ParamBool_TimeBombHeld;

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x7740")]
		public static readonly AnimationParameter ParamBool_toAim;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x7770")]
		public static readonly AnimationParameter ParamBool_toAimVR;

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x77A0")]
		public static readonly AnimationParameter ParamBool_toBook;

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x77D0")]
		public static readonly AnimationParameter ParamBool_toMachine;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x7800")]
		public static readonly AnimationParameter ParamBool_topOpen;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x7830")]
		public static readonly AnimationParameter ParamBool_trackerHeld;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x7860")]
		public static readonly AnimationParameter ParamBool_Tranquilize;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x7890")]
		public static readonly AnimationParameter ParamBool_transitionAllowed;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x78C0")]
		public static readonly AnimationParameter ParamBool_TrapTriggered;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x78F0")]
		public static readonly AnimationParameter ParamBool_UseZipLine;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x7920")]
		public static readonly AnimationParameter ParamBool_VR;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x7950")]
		public static readonly AnimationParameter ParamBool_vrBlock;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x7980")]
		public static readonly AnimationParameter ParamBool_WakeInCoffin;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x79B0")]
		public static readonly AnimationParameter ParamBool_WakeInSpittle;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x79E0")]
		public static readonly AnimationParameter ParamBool_WakeOnEffigy;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x7A10")]
		public static readonly AnimationParameter ParamBool_WakeUnderBodies;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x7A40")]
		public static readonly AnimationParameter ParamBool_WakeUnderWater;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x7A70")]
		public static readonly AnimationParameter ParamBool_wakeUp;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x7AA0")]
		public static readonly AnimationParameter ParamBool_WalkBack;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x7AD0")]
		public static readonly AnimationParameter ParamBool_walkmanHeld;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x7B00")]
		public static readonly AnimationParameter ParamBool_walkmanPlayBool;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x7B30")]
		public static readonly AnimationParameter ParamBool_WallWalk;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x7B60")]
		public static readonly AnimationParameter ParamBool_WashStream;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x7B90")]
		public static readonly AnimationParameter ParamBool_WashWaterfall;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x7BC0")]
		public static readonly AnimationParameter ParamBool_waterSkinHeld;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x7BF0")]
		public static readonly AnimationParameter ParamBool_YellFace;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x7C20")]
		public static readonly AnimationParameter ParamBool_zipLineAttach;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x7C50")]
		public static readonly AnimationParameter ParamTrigger_addTrigger;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x7C80")]
		public static readonly AnimationParameter ParamTrigger_BeginClimbOutA;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x7CB0")]
		public static readonly AnimationParameter ParamTrigger_BeginClimbOutB;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x7CE0")]
		public static readonly AnimationParameter ParamTrigger_BeginClimbOutC;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x7D10")]
		public static readonly AnimationParameter ParamTrigger_BeginCooking;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x7D40")]
		public static readonly AnimationParameter ParamTrigger_BreakAndPlant;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x7D70")]
		public static readonly AnimationParameter ParamTrigger_CameraShakeLargeTrigger;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x7DA0")]
		public static readonly AnimationParameter ParamTrigger_CameraShakeMediumTrigger;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x7DD0")]
		public static readonly AnimationParameter ParamTrigger_CameraShakeSmallTrigger;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x7E00")]
		public static readonly AnimationParameter ParamTrigger_cancelBowTrigger;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x7E30")]
		public static readonly AnimationParameter ParamTrigger_cancelTrigger;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x7E60")]
		public static readonly AnimationParameter ParamTrigger_ClientPredictionTrigger;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x7E90")]
		public static readonly AnimationParameter ParamTrigger_ClimbIntoRaft;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x7EC0")]
		public static readonly AnimationParameter ParamTrigger_ClimbOut;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x7EF0")]
		public static readonly AnimationParameter ParamTrigger_craftTrigger;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x7F20")]
		public static readonly AnimationParameter ParamTrigger_deathTrigger;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x7F50")]
		public static readonly AnimationParameter ParamTrigger_Dialog;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x7F80")]
		public static readonly AnimationParameter ParamTrigger_Disabled;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x7FB0")]
		public static readonly AnimationParameter ParamTrigger_DropBig;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x7FE0")]
		public static readonly AnimationParameter ParamTrigger_dropSmall;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x8010")]
		public static readonly AnimationParameter ParamTrigger_EnterInventoryTrigger;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x8040")]
		public static readonly AnimationParameter ParamTrigger_ExitInventoryTrigger;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x8070")]
		public static readonly AnimationParameter ParamTrigger_fallForward;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x80A0")]
		public static readonly AnimationParameter ParamTrigger_FinishedCooking;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x80D0")]
		public static readonly AnimationParameter ParamTrigger_firstDeathTrigger;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x8100")]
		public static readonly AnimationParameter ParamTrigger_GrabBagTossItem;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x8130")]
		public static readonly AnimationParameter ParamTrigger_HideInShell;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x8160")]
		public static readonly AnimationParameter ParamTrigger_HideInShellFast;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x8190")]
		public static readonly AnimationParameter ParamTrigger_Highlighted;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x81C0")]
		public static readonly AnimationParameter ParamTrigger_injuredTrigger;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x81F0")]
		public static readonly AnimationParameter ParamTrigger_knockBackTrigger;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x8220")]
		public static readonly AnimationParameter ParamTrigger_landHeavyTrigger;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x8250")]
		public static readonly AnimationParameter ParamTrigger_LiftPilarUnderBeam;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x8280")]
		public static readonly AnimationParameter ParamTrigger_LowerRebreatherMouthpiece;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x82B0")]
		public static readonly AnimationParameter ParamTrigger_New_Trigger;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x82E0")]
		public static readonly AnimationParameter ParamTrigger_Normal;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x8310")]
		public static readonly AnimationParameter ParamTrigger_onLadderTrigger;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x8340")]
		public static readonly AnimationParameter ParamTrigger_PauseCooking;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x8370")]
		public static readonly AnimationParameter ParamTrigger_pickupSmall;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x83A0")]
		public static readonly AnimationParameter ParamTrigger_PlaceCarried;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x83D0")]
		public static readonly AnimationParameter ParamTrigger_PlantPilar;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x8400")]
		public static readonly AnimationParameter ParamTrigger_Play;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x8430")]
		public static readonly AnimationParameter ParamTrigger_PlaySequence;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x8460")]
		public static readonly AnimationParameter ParamTrigger_Pressed;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x8490")]
		public static readonly AnimationParameter ParamTrigger_PutOnArmor;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x84C0")]
		public static readonly AnimationParameter ParamTrigger_PutOnClothing;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x84F0")]
		public static readonly AnimationParameter ParamTrigger_RaiseRebreatherMouthpiece;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x8520")]
		public static readonly AnimationParameter ParamTrigger_resetClimbTrigger;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x8550")]
		public static readonly AnimationParameter ParamTrigger_resetTrigger;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x8580")]
		public static readonly AnimationParameter ParamTrigger_ResumeCooking;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x85B0")]
		public static readonly AnimationParameter ParamTrigger_Selected;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x85E0")]
		public static readonly AnimationParameter ParamTrigger_setClimbTopTrigger;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x8610")]
		public static readonly AnimationParameter ParamTrigger_setClimbTrigger;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x8640")]
		public static readonly AnimationParameter ParamTrigger_StartBlock;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x8670")]
		public static readonly AnimationParameter ParamTrigger_toSelf_0;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x86A0")]
		public static readonly AnimationParameter ParamTrigger_toSelf_0_5;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x86D0")]
		public static readonly AnimationParameter ParamTrigger_toSelf_1;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x8700")]
		public static readonly AnimationParameter ParamTrigger_toSelf_5;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x8730")]
		public static readonly AnimationParameter ParamTrigger_Trigger;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x8760")]
		public static readonly AnimationParameter ParamTrigger_WakeUpOnBeach;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x8790")]
		public static readonly AnimationParameter Layer_Additive;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x87C0")]
		public static readonly AnimationParameter Layer_AdditiveArms;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x87F0")]
		public static readonly AnimationParameter Layer_Aiming;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x8820")]
		public static readonly AnimationParameter Layer_AttackFullbodyOverride;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x8850")]
		public static readonly AnimationParameter Layer_Base_Layer;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x8880")]
		public static readonly AnimationParameter Layer_Blink;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x88B0")]
		public static readonly AnimationParameter Layer_BoatEngine;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x88E0")]
		public static readonly AnimationParameter Layer_ButtonLayer;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x8910")]
		public static readonly AnimationParameter Layer_chainLayer;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x8940")]
		public static readonly AnimationParameter Layer_ClientPredictionLayer;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x8970")]
		public static readonly AnimationParameter Layer_EyeOverride;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x89A0")]
		public static readonly AnimationParameter Layer_Face;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x89D0")]
		public static readonly AnimationParameter Layer_FullBody;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x8A00")]
		public static readonly AnimationParameter Layer_fullBodyActions;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x8A30")]
		public static readonly AnimationParameter Layer_HelicopterFullBody;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x8A60")]
		public static readonly AnimationParameter Layer_Hits;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x8A90")]
		public static readonly AnimationParameter Layer_Inventory;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x8AC0")]
		public static readonly AnimationParameter Layer_InventoryUpperBody;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x8AF0")]
		public static readonly AnimationParameter Layer_Jaw;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x8B20")]
		public static readonly AnimationParameter Layer_leftArm;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x8B50")]
		public static readonly AnimationParameter Layer_leftRunroll;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x8B80")]
		public static readonly AnimationParameter Layer_Limping;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x8BB0")]
		public static readonly AnimationParameter Layer_lookBlends;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x8BE0")]
		public static readonly AnimationParameter Layer_New_Layer;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x8C10")]
		public static readonly AnimationParameter Layer_spineAddititve2;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x8C40")]
		public static readonly AnimationParameter Layer_ThirdArm;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x8C70")]
		public static readonly AnimationParameter Layer_topUnroll;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x8CA0")]
		public static readonly AnimationParameter Layer_upperBody;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x8CD0")]
		public static readonly AnimationParameter Layer_UpperBody;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x8D00")]
		public static readonly AnimationParameter Layer_Upperbody_Aiming;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x8D30")]
		public static readonly AnimationParameter Layer_UpperBodyArms;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x8D60")]
		public static readonly AnimationParameter Layer_UpperBodyHelicopter;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x8D90")]
		public static readonly AnimationParameter Layer_UpperBodyReactions;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x8DC0")]
		public static readonly AnimationParameter Layer_Wings;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x8DF0")]
		public static readonly AnimationParameter State_3dPrintedGrapplingHookCraftZiplineRope;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x8E20")]
		public static readonly AnimationParameter State_3dPrintedGrapplingHookIdle;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x8E50")]
		public static readonly AnimationParameter State_9mmAmmoCraftLootPouch;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x8E80")]
		public static readonly AnimationParameter State_9mmAmmoIdle;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x8EB0")]
		public static readonly AnimationParameter State_ActionCameraEquip;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x8EE0")]
		public static readonly AnimationParameter State_ActionCameraFirstLook;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x8F10")]
		public static readonly AnimationParameter State_ActionCameraIdle;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x8F40")]
		public static readonly AnimationParameter State_ActionCameraIdleToView;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x8F70")]
		public static readonly AnimationParameter State_ActionCameraUnequip;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x8FA0")]
		public static readonly AnimationParameter State_ActionCameraView;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x8FD0")]
		public static readonly AnimationParameter State_ActionCameraViewToIdle;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x9000")]
		public static readonly AnimationParameter State_AdditiveDefaultPassthrough;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x9030")]
		public static readonly AnimationParameter State_AdditiveHitReactBody;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x9060")]
		public static readonly AnimationParameter State_AdditiveHitReactHead;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x9090")]
		public static readonly AnimationParameter State_addJump;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x90C0")]
		public static readonly AnimationParameter State_Aim_Forward;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x90F0")]
		public static readonly AnimationParameter State_AimdodgeToAim;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x9120")]
		public static readonly AnimationParameter State_aimFlareIdle;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x9150")]
		public static readonly AnimationParameter State_aimIdle;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x9180")]
		public static readonly AnimationParameter State_aimIdleShoot;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x91B0")]
		public static readonly AnimationParameter State_Aiming;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x91E0")]
		public static readonly AnimationParameter State_AimNotched;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x9210")]
		public static readonly AnimationParameter State_AimNotchedFar;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x9240")]
		public static readonly AnimationParameter State_AimNotchedFarToCarry;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x9270")]
		public static readonly AnimationParameter State_AimNotchedLog;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x92A0")]
		public static readonly AnimationParameter State_AimNotchedLogFar;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x92D0")]
		public static readonly AnimationParameter State_AimNotchedToCarry;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x9300")]
		public static readonly AnimationParameter State_AimPilarUnderBeam;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x9330")]
		public static readonly AnimationParameter State_AimPilarUnderBeamR;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x9360")]
		public static readonly AnimationParameter State_AimPilarUnderBeamToCarry;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x9390")]
		public static readonly AnimationParameter State_AimPilarUnderBeamToCarryR;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x93C0")]
		public static readonly AnimationParameter State_AimPlantPilarIdle;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x93F0")]
		public static readonly AnimationParameter State_AimPlantPilarIdleR;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x9420")]
		public static readonly AnimationParameter State_AimPlantPilarIdleToCarry;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x9450")]
		public static readonly AnimationParameter State_AimPlantPilarIdleToCarryR;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x9480")]
		public static readonly AnimationParameter State_AimPlantPilarToCarryLog;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x94B0")]
		public static readonly AnimationParameter State_AimRoof;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x94E0")]
		public static readonly AnimationParameter State_AimRoofLog;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x9510")]
		public static readonly AnimationParameter State_AimRoofToCarry;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x9540")]
		public static readonly AnimationParameter State_aimSlingVR;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x9570")]
		public static readonly AnimationParameter State_AimStrutUnderBeam;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x95A0")]
		public static readonly AnimationParameter State_AimStrutUnderBeamToCarry;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x95D0")]
		public static readonly AnimationParameter State_AimToRun180;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x9600")]
		public static readonly AnimationParameter State_AimToRunLeft;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x9630")]
		public static readonly AnimationParameter State_AimToRunRight;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x9660")]
		public static readonly AnimationParameter State_Airborne;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x9690")]
		public static readonly AnimationParameter State_AlbumEquip;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x96C0")]
		public static readonly AnimationParameter State_AlbumIdle;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x96F0")]
		public static readonly AnimationParameter State_AlertedLeft;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x9720")]
		public static readonly AnimationParameter State_AlertedLeftToIdle;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x9750")]
		public static readonly AnimationParameter State_AlertedRight;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x9780")]
		public static readonly AnimationParameter State_AlertedRightToIdle;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x97B0")]
		public static readonly AnimationParameter State_AloeVeraCraftHerbMix;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x97E0")]
		public static readonly AnimationParameter State_AloeVeraIdle;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x9810")]
		public static readonly AnimationParameter State_Angry;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x9840")]
		public static readonly AnimationParameter State_Animation_Loop_10s_1;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x9870")]
		public static readonly AnimationParameter State_Animation_Loop_10s_2;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x98A0")]
		public static readonly AnimationParameter State_Animation_Loop_1s_1;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x98D0")]
		public static readonly AnimationParameter State_Animation_Loop_1s_2;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x9900")]
		public static readonly AnimationParameter State_Animation_NoLoop_1;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x9930")]
		public static readonly AnimationParameter State_Animation_NoLoop_2;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x9960")]
		public static readonly AnimationParameter State_AnimJumpA;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x9990")]
		public static readonly AnimationParameter State_AnimJumpB;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x99C0")]
		public static readonly AnimationParameter State_AnimJumpC;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x99F0")]
		public static readonly AnimationParameter State_armOverride;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x9A20")]
		public static readonly AnimationParameter State_ArrowleafBalsamrootCraftHerbMix;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x9A50")]
		public static readonly AnimationParameter State_ArrowleafBalsamrootIdle;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x9A80")]
		public static readonly AnimationParameter State_artifactActivate;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x9AB0")]
		public static readonly AnimationParameter State_artifactIdle;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x9AE0")]
		public static readonly AnimationParameter State_artifactPickup;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x9B10")]
		public static readonly AnimationParameter State_artifactPutDown;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x9B40")]
		public static readonly AnimationParameter State_Attack180;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x9B70")]
		public static readonly AnimationParameter State_Attack180LeftA;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x9BA0")]
		public static readonly AnimationParameter State_Attack180LeftBack;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x9BD0")]
		public static readonly AnimationParameter State_Attack180RightA;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x9C00")]
		public static readonly AnimationParameter State_Attack180RightBack;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x9C30")]
		public static readonly AnimationParameter State_AttackA;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x9C60")]
		public static readonly AnimationParameter State_AttackB;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x9C90")]
		public static readonly AnimationParameter State_AttackBehind;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x9CC0")]
		public static readonly AnimationParameter State_attackBehind1;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x9CF0")]
		public static readonly AnimationParameter State_AttackBehindLeft;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x9D20")]
		public static readonly AnimationParameter State_AttackBehindRight;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x9D50")]
		public static readonly AnimationParameter State_AttackC;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x9D80")]
		public static readonly AnimationParameter State_AttackComboForward1SmallerBodyOnTop;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x9DB0")]
		public static readonly AnimationParameter State_AttackComboForward1SmallerBodyOnTopToIdleSmallerBodyOnTop;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x9DE0")]
		public static readonly AnimationParameter State_AttackCWeapon;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x9E10")]
		public static readonly AnimationParameter State_AttackD;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x9E40")]
		public static readonly AnimationParameter State_AttackDWeapon;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x9E70")]
		public static readonly AnimationParameter State_AttackForward;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x9EA0")]
		public static readonly AnimationParameter State_AttackForwardA;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x9ED0")]
		public static readonly AnimationParameter State_AttackForwardB;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x9F00")]
		public static readonly AnimationParameter State_AttackForwardCombo2;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x9F30")]
		public static readonly AnimationParameter State_AttackForwardCombo3;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x9F60")]
		public static readonly AnimationParameter State_AttackIdle;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x9F90")]
		public static readonly AnimationParameter State_AttackLeft;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x9FC0")]
		public static readonly AnimationParameter State_AttackLeftA;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x9FF0")]
		public static readonly AnimationParameter State_AttackLow;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0xA020")]
		public static readonly AnimationParameter State_AttackLowC;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0xA050")]
		public static readonly AnimationParameter State_AttackLowD;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0xA080")]
		public static readonly AnimationParameter State_AttackLunge;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0xA0B0")]
		public static readonly AnimationParameter State_AttackLungeForward;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0xA0E0")]
		public static readonly AnimationParameter State_AttackMid;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0xA110")]
		public static readonly AnimationParameter State_AttackPassThrough;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0xA140")]
		public static readonly AnimationParameter State_AttackRight;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0xA170")]
		public static readonly AnimationParameter State_AttackRightA;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0xA1A0")]
		public static readonly AnimationParameter State_AttackRockJumpA;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0xA1D0")]
		public static readonly AnimationParameter State_AttackRockJumpB;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0xA200")]
		public static readonly AnimationParameter State_AttackTest;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0xA230")]
		public static readonly AnimationParameter State_attackToIdle;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0xA260")]
		public static readonly AnimationParameter State_AttackWallA;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0xA290")]
		public static readonly AnimationParameter State_AttackWallAHit01;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0xA2C0")]
		public static readonly AnimationParameter State_AttackWallAHit02;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0xA2F0")]
		public static readonly AnimationParameter State_AttackWallAHit03;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0xA320")]
		public static readonly AnimationParameter State_AttackWallB;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0xA350")]
		public static readonly AnimationParameter State_AttackWallC;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0xA380")]
		public static readonly AnimationParameter State_AttackWallCHit01;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0xA3B0")]
		public static readonly AnimationParameter State_AttackWallClub;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0xA3E0")]
		public static readonly AnimationParameter State_AttackWallCombo;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0xA410")]
		public static readonly AnimationParameter State_AttackWallD;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0xA440")]
		public static readonly AnimationParameter State_AttackWallEngine;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0xA470")]
		public static readonly AnimationParameter State_awake;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0xA4A0")]
		public static readonly AnimationParameter State_axeAttackGround1;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0xA4D0")]
		public static readonly AnimationParameter State_axeAttackGround1_0;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0xA500")]
		public static readonly AnimationParameter State_axeHeavyAttack;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0xA530")]
		public static readonly AnimationParameter State_axeheavyAttackWindup;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0xA560")]
		public static readonly AnimationParameter State_axeToAxeAttack;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0xA590")]
		public static readonly AnimationParameter State_BackAway;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0xA5C0")]
		public static readonly AnimationParameter State_BackAwayEnd;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0xA5F0")]
		public static readonly AnimationParameter State_BackAwayStart;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0xA620")]
		public static readonly AnimationParameter State_BackAwayToIdle;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0xA650")]
		public static readonly AnimationParameter State_Background_In;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0xA680")]
		public static readonly AnimationParameter State_BackpackEquip;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0xA6B0")]
		public static readonly AnimationParameter State_BackpackEquipCrouched;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0xA6E0")]
		public static readonly AnimationParameter State_BackpackIdle;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0xA710")]
		public static readonly AnimationParameter State_BackpackIdleCrouched;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0xA740")]
		public static readonly AnimationParameter State_BackpackUnequip;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0xA770")]
		public static readonly AnimationParameter State_BackpackUnequipCrouched;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0xA7A0")]
		public static readonly AnimationParameter State_BadGuyEscapeCutscene;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0xA7D0")]
		public static readonly AnimationParameter State_BadGuyIntro;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0xA800")]
		public static readonly AnimationParameter State_BagInventoryUnwrap;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0xA830")]
		public static readonly AnimationParameter State_ballIdle;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0xA860")]
		public static readonly AnimationParameter State_base;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0xA890")]
		public static readonly AnimationParameter State_BashBody;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0xA8C0")]
		public static readonly AnimationParameter State_Basic_Fade_in;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0xA8F0")]
		public static readonly AnimationParameter State_Basic_Fade_out;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0xA920")]
		public static readonly AnimationParameter State_BatDeathTemp;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0xA950")]
		public static readonly AnimationParameter State_BatLand;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0xA980")]
		public static readonly AnimationParameter State_BatTakeoff;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0xA9B0")]
		public static readonly AnimationParameter State_BatteriesCraftTechArmor;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0xA9E0")]
		public static readonly AnimationParameter State_BatteriesIdle;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0xAA10")]
		public static readonly AnimationParameter State_BatteryPackIdle;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0xAA40")]
		public static readonly AnimationParameter State_BeckonPlayer01;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0xAA70")]
		public static readonly AnimationParameter State_BeckonPlayer02;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0xAAA0")]
		public static readonly AnimationParameter State_beforeCrash;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0xAAD0")]
		public static readonly AnimationParameter State_BeginCooking;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0xAB00")]
		public static readonly AnimationParameter State_BellyFlopAttack;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0xAB30")]
		public static readonly AnimationParameter State_BenderAnimation;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0xAB60")]
		public static readonly AnimationParameter State_binocularIdle;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0xAB90")]
		public static readonly AnimationParameter State_binocularsLookIdle;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0xABC0")]
		public static readonly AnimationParameter State_birdOnHand;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0xABF0")]
		public static readonly AnimationParameter State_BiteAttack;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0xAC20")]
		public static readonly AnimationParameter State_BiteAttackClose;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0xAC50")]
		public static readonly AnimationParameter State_Blend_Tree;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0xAC80")]
		public static readonly AnimationParameter State_Blink;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0xACB0")]
		public static readonly AnimationParameter State_blocked;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0xACE0")]
		public static readonly AnimationParameter State_BlockedLeftA;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0xAD10")]
		public static readonly AnimationParameter State_BlockedRightA;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0xAD40")]
		public static readonly AnimationParameter State_BlockFrontA;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0xAD70")]
		public static readonly AnimationParameter State_BlockFrontB;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0xADA0")]
		public static readonly AnimationParameter State_BlockIdle;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0xADD0")]
		public static readonly AnimationParameter State_BlockIdleAHitA;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0xAE00")]
		public static readonly AnimationParameter State_BlockIdleAHitB;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0xAE30")]
		public static readonly AnimationParameter State_BlockIdleB;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0xAE60")]
		public static readonly AnimationParameter State_BlockIdleBHitA;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0xAE90")]
		public static readonly AnimationParameter State_BlockIdleBHitB;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0xAEC0")]
		public static readonly AnimationParameter State_BlockIdleBHitC;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0xAEF0")]
		public static readonly AnimationParameter State_BlockIdleHitA;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0xAF20")]
		public static readonly AnimationParameter State_BlockIdleIntro;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0xAF50")]
		public static readonly AnimationParameter State_BlockIdleIntroB;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0xAF80")]
		public static readonly AnimationParameter State_BlockIdleOutro;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0xAFB0")]
		public static readonly AnimationParameter State_BlockIdleOutroB;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0xAFE0")]
		public static readonly AnimationParameter State_BlockLeftA;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0xB010")]
		public static readonly AnimationParameter State_BlockLeftB;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0xB040")]
		public static readonly AnimationParameter State_BlockRightA;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0xB070")]
		public static readonly AnimationParameter State_BlockRightB;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0xB0A0")]
		public static readonly AnimationParameter State_BlueberriesCraftLootPouch;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0xB0D0")]
		public static readonly AnimationParameter State_BlueberriesIdle;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0xB100")]
		public static readonly AnimationParameter State_BoatEngineOverrideIdle;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0xB130")]
		public static readonly AnimationParameter State_BodySlamForwardA;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0xB160")]
		public static readonly AnimationParameter State_BodySwipeForwardA;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0xB190")]
		public static readonly AnimationParameter State_BodySwipeLeft;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0xB1C0")]
		public static readonly AnimationParameter State_BodySwipeRightA;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0xB1F0")]
		public static readonly AnimationParameter State_BoneACraftBoneArmor;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0xB220")]
		public static readonly AnimationParameter State_BoneArmourCraftBoneArmor;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0xB250")]
		public static readonly AnimationParameter State_BoneArmourIdle;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0xB280")]
		public static readonly AnimationParameter State_BoneBCraftBoneArmor;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0xB2B0")]
		public static readonly AnimationParameter State_BoneCCraftBoneArmor;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0xB2E0")]
		public static readonly AnimationParameter State_BoneDCraftBoneArmor;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0xB310")]
		public static readonly AnimationParameter State_BoneIdle;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0xB340")]
		public static readonly AnimationParameter State_BoneMakerResetTrap;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0xB370")]
		public static readonly AnimationParameter State_BoneMakerTrapIdle;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0xB3A0")]
		public static readonly AnimationParameter State_BoneMakerTriggerTrap;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0xB3D0")]
		public static readonly AnimationParameter State_BonePlantAndTwistToIdle;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0xB400")]
		public static readonly AnimationParameter State_bookIdle;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0xB430")]
		public static readonly AnimationParameter State_bookIdleToIdle;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0xB460")]
		public static readonly AnimationParameter State_BookTabSlideIn;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0xB490")]
		public static readonly AnimationParameter State_BookTabSlideOut;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0xB4C0")]
		public static readonly AnimationParameter State_BossMutantIntro;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0xB4F0")]
		public static readonly AnimationParameter State_BossMutantIntroBossMutant;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0xB520")]
		public static readonly AnimationParameter State_BossMutantIntroCutscene;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0xB550")]
		public static readonly AnimationParameter State_BossMutantIntroCutsceneGround;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0xB580")]
		public static readonly AnimationParameter State_BossMutantIntroHelicopter;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0xB5B0")]
		public static readonly AnimationParameter State_BossMutantIntroHelicopterA;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0xB5E0")]
		public static readonly AnimationParameter State_BossMutantIntroMutantBaby;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0xB610")]
		public static readonly AnimationParameter State_BossMutantIntroMutantBabyA;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0xB640")]
		public static readonly AnimationParameter State_BossMutantIntroMutantBabyB;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0xB670")]
		public static readonly AnimationParameter State_BossMutantIntroRockCluster;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0xB6A0")]
		public static readonly AnimationParameter State_BossMutantIntroTacticool;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0xB6D0")]
		public static readonly AnimationParameter State_BossMutantIntroTimmy;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0xB700")]
		public static readonly AnimationParameter State_BossMutantIntroTimmyMutantArm;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0xB730")]
		public static readonly AnimationParameter State_BossMutantIntroTimmyMutantArmA;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0xB760")]
		public static readonly AnimationParameter State_Bounce;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0xB790")]
		public static readonly AnimationParameter State_bowIdle;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0xB7C0")]
		public static readonly AnimationParameter State_bowPull_VR;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0xB7F0")]
		public static readonly AnimationParameter State_Boxing;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0xB820")]
		public static readonly AnimationParameter State_Breakout;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0xB850")]
		public static readonly AnimationParameter State_BreakoutEndHold;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0xB880")]
		public static readonly AnimationParameter State_BreakStickStanding;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0xB8B0")]
		public static readonly AnimationParameter State_BreezeStrong;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0xB8E0")]
		public static readonly AnimationParameter State_BuckshotAmmoCraftLootPouch;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0xB910")]
		public static readonly AnimationParameter State_BuckshotAmmoIdle;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0xB940")]
		public static readonly AnimationParameter State_BuildFire;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0xB970")]
		public static readonly AnimationParameter State_BuildingCutWindow;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0xB9A0")]
		public static readonly AnimationParameter State_BuildingCutWindowAxeChop;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0xB9D0")]
		public static readonly AnimationParameter State_bunkerScene;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0xBA00")]
		public static readonly AnimationParameter State_burnAway;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0xBA30")]
		public static readonly AnimationParameter State_Burning;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0xBA60")]
		public static readonly AnimationParameter State_BurningDeath;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0xBA90")]
		public static readonly AnimationParameter State_BurningOnGround;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0xBAC0")]
		public static readonly AnimationParameter State_bushWobble1;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0xBAF0")]
		public static readonly AnimationParameter State_ButterflyFly;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0xBB20")]
		public static readonly AnimationParameter State_ButterflyIdle;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0xBB50")]
		public static readonly AnimationParameter State_C4BrickCraftTimeBomb;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0xBB80")]
		public static readonly AnimationParameter State_C4BrickIdle;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0xBBB0")]
		public static readonly AnimationParameter State_camCorderIdle;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0xBBE0")]
		public static readonly AnimationParameter State_CameraShakeBlend;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0xBC10")]
		public static readonly AnimationParameter State_CameraShakeLarge;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0xBC40")]
		public static readonly AnimationParameter State_CameraShakeLooping;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0xBC70")]
		public static readonly AnimationParameter State_CameraShakeMedium;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0xBCA0")]
		public static readonly AnimationParameter State_CameraShakePassthrough;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0xBCD0")]
		public static readonly AnimationParameter State_CameraShakeSmall;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0xBD00")]
		public static readonly AnimationParameter State_camerazoom;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0xBD30")]
		public static readonly AnimationParameter State_campDrinkIdle;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0xBD60")]
		public static readonly AnimationParameter State_campedToDrinkIdle;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0xBD90")]
		public static readonly AnimationParameter State_campingToAimForward;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0xBDC0")]
		public static readonly AnimationParameter State_campingToCrouchedIdle;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0xBDF0")]
		public static readonly AnimationParameter State_campingToCrouchedIdle_0;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0xBE20")]
		public static readonly AnimationParameter State_campSitting;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0xBE50")]
		public static readonly AnimationParameter State_campSittingToIdle;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0xBE80")]
		public static readonly AnimationParameter State_camShake1;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0xBEB0")]
		public static readonly AnimationParameter State_camShake2;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0xBEE0")]
		public static readonly AnimationParameter State_camShakeFall;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0xBF10")]
		public static readonly AnimationParameter State_camShakePlane;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0xBF40")]
		public static readonly AnimationParameter State_camShakePlaneGround;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0xBF70")]
		public static readonly AnimationParameter State_camShakePlaneStart;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0xBFA0")]
		public static readonly AnimationParameter State_camShakeZipline;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0xBFD0")]
		public static readonly AnimationParameter State_CannedFoodCraftCatFood;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0xC000")]
		public static readonly AnimationParameter State_CannedFoodIdle;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0xC030")]
		public static readonly AnimationParameter State_CanOpenerCraftCatFood;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0xC060")]
		public static readonly AnimationParameter State_CanOpenerIdle;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0xC090")]
		public static readonly AnimationParameter State_carryBody;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0xC0C0")]
		public static readonly AnimationParameter State_carryBodyWalk;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0xC0F0")]
		public static readonly AnimationParameter State_CarryItem;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0xC120")]
		public static readonly AnimationParameter State_carryLog;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0xC150")]
		public static readonly AnimationParameter State_CarryLog;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0xC180")]
		public static readonly AnimationParameter State_CarryLogToAimNotchedLog;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0xC1B0")]
		public static readonly AnimationParameter State_CarryLogToAimNotchedLog_0;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0xC1E0")]
		public static readonly AnimationParameter State_CarryLogToAimNotchedLogFar;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0xC210")]
		public static readonly AnimationParameter State_CarryLogToAimNotchedLogFar_0;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0xC240")]
		public static readonly AnimationParameter State_CarryLogToAimPilarUnderBeam;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0xC270")]
		public static readonly AnimationParameter State_CarryLogToAimPlantPilarIdle;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0xC2A0")]
		public static readonly AnimationParameter State_CarryLogToAimRoofLog;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0xC2D0")]
		public static readonly AnimationParameter State_CarryLogToAimRoofLog_0;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0xC300")]
		public static readonly AnimationParameter State_CarryLogToIdle;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0xC330")]
		public static readonly AnimationParameter State_CarryStick;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0xC360")]
		public static readonly AnimationParameter State_CarryStructureElementIdle;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0xC390")]
		public static readonly AnimationParameter State_carryToPlaceFloorIdle;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0xC3C0")]
		public static readonly AnimationParameter State_carryToPlaceFloorIdle_0;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0xC3F0")]
		public static readonly AnimationParameter State_carryToPlaceLogFlat;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0xC420")]
		public static readonly AnimationParameter State_carryToPlaceLogFlat_0;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0xC450")]
		public static readonly AnimationParameter State_CatchBreath;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0xC480")]
		public static readonly AnimationParameter State_CatchFishIdle;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0xC4B0")]
		public static readonly AnimationParameter State_CatchFishSuccess;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0xC4E0")]
		public static readonly AnimationParameter State_CatFoodCraftCatFood;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0xC510")]
		public static readonly AnimationParameter State_CatFoodIdle;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0xC540")]
		public static readonly AnimationParameter State_chainLoop;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0xC570")]
		public static readonly AnimationParameter State_chainSawAttack;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0xC5A0")]
		public static readonly AnimationParameter State_chainSawAttack_0;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0xC5D0")]
		public static readonly AnimationParameter State_ChainsawAttackA;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0xC600")]
		public static readonly AnimationParameter State_ChainsawAttackB;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0xC630")]
		public static readonly AnimationParameter State_ChainsawAttackC;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0xC660")]
		public static readonly AnimationParameter State_chainSawAttackToIdle;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0xC690")]
		public static readonly AnimationParameter State_chainSawAttackToIdle_0;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0xC6C0")]
		public static readonly AnimationParameter State_ChainsawAttackToLeftA;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0xC6F0")]
		public static readonly AnimationParameter State_ChainsawAttackToRightA;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0xC720")]
		public static readonly AnimationParameter State_ChainsawAttackToRightHeavyAttackWindup;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0xC750")]
		public static readonly AnimationParameter State_ChainsawBlockedLeftA;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0xC780")]
		public static readonly AnimationParameter State_ChainsawBlockedRightA;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0xC7B0")]
		public static readonly AnimationParameter State_ChainsawCutTreeA;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0xC7E0")]
		public static readonly AnimationParameter State_ChainsawCutTreeAToIdleHeld;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0xC810")]
		public static readonly AnimationParameter State_ChainsawCutTreeB;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0xC840")]
		public static readonly AnimationParameter State_ChainsawCutTreeBToIdleHeld;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0xC870")]
		public static readonly AnimationParameter State_ChainsawFirstGet;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0xC8A0")]
		public static readonly AnimationParameter State_ChainsawGround;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0xC8D0")]
		public static readonly AnimationParameter State_ChainsawHeavyAttack;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0xC900")]
		public static readonly AnimationParameter State_ChainsawHeavyAttackOnHit;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0xC930")]
		public static readonly AnimationParameter State_ChainsawHeavyAttackWindup;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0xC960")]
		public static readonly AnimationParameter State_chainSawIdle;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0xC990")]
		public static readonly AnimationParameter State_chainSawIdle_0;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0xC9C0")]
		public static readonly AnimationParameter State_chainSawIdle_1;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0xC9F0")]
		public static readonly AnimationParameter State_ChainsawIdleHeld;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0xCA20")]
		public static readonly AnimationParameter State_ChainsawIdleHeldEngineOn;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0xCA50")]
		public static readonly AnimationParameter State_ChainsawIdleHeldToCutTreeA;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0xCA80")]
		public static readonly AnimationParameter State_ChainsawIdleHeldToCutTreeB;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0xCAB0")]
		public static readonly AnimationParameter State_ChainsawIdleToRevEngine;

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0xCAE0")]
		public static readonly AnimationParameter State_ChainsawReload;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0xCB10")]
		public static readonly AnimationParameter State_ChainsawRevEngine;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0xCB40")]
		public static readonly AnimationParameter State_ChainsawRevEngineOnHit;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0xCB70")]
		public static readonly AnimationParameter State_ChainsawRevEngineToIdle;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0xCBA0")]
		public static readonly AnimationParameter State_chainSawToIdle;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0xCBD0")]
		public static readonly AnimationParameter State_chainSawToIdle_0;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0xCC00")]
		public static readonly AnimationParameter State_ChargeAttackA;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0xCC30")]
		public static readonly AnimationParameter State_checkArms;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0xCC60")]
		public static readonly AnimationParameter State_ChicoryCraftHerbMix;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0xCC90")]
		public static readonly AnimationParameter State_ChicoryIdle;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0xCCC0")]
		public static readonly AnimationParameter State_ChopperCreditsCutscene;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0xCCF0")]
		public static readonly AnimationParameter State_ChopperExit;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0xCD20")]
		public static readonly AnimationParameter State_ChopperExitCutscene;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0xCD50")]
		public static readonly AnimationParameter State_ChopperGroupLeaveIslandCutscene;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0xCD80")]
		public static readonly AnimationParameter State_ChopperPlayerLeaveIslandCutscene;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0xCDB0")]
		public static readonly AnimationParameter State_ChopperRobbyLeaveIslandCutscene;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0xCDE0")]
		public static readonly AnimationParameter State_ChopperVirginiaLeaveIslandCutscene;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0xCE10")]
		public static readonly AnimationParameter State_CircleLeft;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0xCE40")]
		public static readonly AnimationParameter State_CircleLeftFast;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0xCE70")]
		public static readonly AnimationParameter State_CircleLeftToIdle;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0xCEA0")]
		public static readonly AnimationParameter State_CircleLeftToIdleFast;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0xCED0")]
		public static readonly AnimationParameter State_CircleRight;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0xCF00")]
		public static readonly AnimationParameter State_CircleRightFast;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0xCF30")]
		public static readonly AnimationParameter State_CircleRightToIdle;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0xCF60")]
		public static readonly AnimationParameter State_CircleRightToIdleFast;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0xCF90")]
		public static readonly AnimationParameter State_CircuitBoardCraftTechArmor;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0xCFC0")]
		public static readonly AnimationParameter State_CircuitBoardCraftTimeBomb;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0xCFF0")]
		public static readonly AnimationParameter State_CircuitBoardIdle;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0xD020")]
		public static readonly AnimationParameter State_ClappingA;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0xD050")]
		public static readonly AnimationParameter State_ClappingB;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0xD080")]
		public static readonly AnimationParameter State_ClearBrush;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0xD0B0")]
		public static readonly AnimationParameter State_ClearTarp;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0xD0E0")]
		public static readonly AnimationParameter State_clientTimmyCutScene;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0xD110")]
		public static readonly AnimationParameter State_clientWakOnPlane;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0xD140")]
		public static readonly AnimationParameter State_ClimbFast;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0xD170")]
		public static readonly AnimationParameter State_ClimbIdle;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0xD1A0")]
		public static readonly AnimationParameter State_climbIdle;

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0xD1D0")]
		public static readonly AnimationParameter State_climbIdleLeftToClimb;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0xD200")]
		public static readonly AnimationParameter State_climbIdleLeftToClimb_0;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0xD230")]
		public static readonly AnimationParameter State_ClimbIntoWindow;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0xD260")]
		public static readonly AnimationParameter State_ClimbLadderDownLoop;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0xD290")]
		public static readonly AnimationParameter State_ClimbLadderDownOutro;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0xD2C0")]
		public static readonly AnimationParameter State_ClimbLadderDownOutroB;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0xD2F0")]
		public static readonly AnimationParameter State_ClimbLadderUpIntro;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0xD320")]
		public static readonly AnimationParameter State_ClimbLadderUpIntroB;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0xD350")]
		public static readonly AnimationParameter State_ClimbLadderUpLoop;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0xD380")]
		public static readonly AnimationParameter State_ClimbLadderUpOutro;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0xD3B0")]
		public static readonly AnimationParameter State_climbLoopDown;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0xD3E0")]
		public static readonly AnimationParameter State_climbLoopDown_0;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0xD410")]
		public static readonly AnimationParameter State_climbLoopDownLeftHandToIdle;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0xD440")]
		public static readonly AnimationParameter State_climbLoopDownRightHandToIdle;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0xD470")]
		public static readonly AnimationParameter State_climbLoopLeft;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0xD4A0")]
		public static readonly AnimationParameter State_climbLoopRight;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0xD4D0")]
		public static readonly AnimationParameter State_climbLoopToIdle;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0xD500")]
		public static readonly AnimationParameter State_climbLoopUp;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0xD530")]
		public static readonly AnimationParameter State_climbLoopUp_0;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0xD560")]
		public static readonly AnimationParameter State_ClimbOut;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0xD590")]
		public static readonly AnimationParameter State_ClimbOutB_Hit;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0xD5C0")]
		public static readonly AnimationParameter State_ClimbOutB_Hit_Repeat;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0xD5F0")]
		public static readonly AnimationParameter State_ClimbOutOfHole;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0xD620")]
		public static readonly AnimationParameter State_ClimbOverWall;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0xD650")]
		public static readonly AnimationParameter State_climbSlideDown;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0xD680")]
		public static readonly AnimationParameter State_ClimbSlow;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0xD6B0")]
		public static readonly AnimationParameter State_ClimbStickLadderIntroBottom;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0xD6E0")]
		public static readonly AnimationParameter State_ClimbStickLadderLoopDown;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0xD710")]
		public static readonly AnimationParameter State_ClimbStickLadderLoopUp;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0xD740")]
		public static readonly AnimationParameter State_ClimbStickLadderOutroBottom;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0xD770")]
		public static readonly AnimationParameter State_ClimbStickLadderOutroTop;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0xD7A0")]
		public static readonly AnimationParameter State_climbToIdle;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0xD7D0")]
		public static readonly AnimationParameter State_climbToIdle_0;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0xD800")]
		public static readonly AnimationParameter State_climbToIdle_0_0;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0xD830")]
		public static readonly AnimationParameter State_climbToIdle_1;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0xD860")]
		public static readonly AnimationParameter State_ClimbWall;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0xD890")]
		public static readonly AnimationParameter State_ClimbWallLoop;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0xD8C0")]
		public static readonly AnimationParameter State_Clip_1;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0xD8F0")]
		public static readonly AnimationParameter State_close;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0xD920")]
		public static readonly AnimationParameter State_CloseCase;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0xD950")]
		public static readonly AnimationParameter State_closed;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0xD980")]
		public static readonly AnimationParameter State_ClothCraftCraftedLeafArmor;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0xD9B0")]
		public static readonly AnimationParameter State_ClothCraftCraftedTorch;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0xD9E0")]
		public static readonly AnimationParameter State_ClothCraftDeerHideArmour;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0xDA10")]
		public static readonly AnimationParameter State_ClothCraftLootPouch;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0xDA40")]
		public static readonly AnimationParameter State_ClothCraftMolotov;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0xDA70")]
		public static readonly AnimationParameter State_ClothIdle;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0xDAA0")]
		public static readonly AnimationParameter State_ClubAttackToLeftA;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0xDAD0")]
		public static readonly AnimationParameter State_ClubAttackToRightA;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0xDB00")]
		public static readonly AnimationParameter State_clubBlock1;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0xDB30")]
		public static readonly AnimationParameter State_ClubBlock1;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0xDB60")]
		public static readonly AnimationParameter State_ClubBlock2;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0xDB90")]
		public static readonly AnimationParameter State_clubBlock2;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0xDBC0")]
		public static readonly AnimationParameter State_ClubBlockedLeftA;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0xDBF0")]
		public static readonly AnimationParameter State_ClubBlockedRightA;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0xDC20")]
		public static readonly AnimationParameter State_clubBlockHit1;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0xDC50")]
		public static readonly AnimationParameter State_ClubBlockHit1;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0xDC80")]
		public static readonly AnimationParameter State_ClubBlockHit2;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0xDCB0")]
		public static readonly AnimationParameter State_clubBlockHit2;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0xDCE0")]
		public static readonly AnimationParameter State_clubBlockToIdle;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0xDD10")]
		public static readonly AnimationParameter State_ClubBlockToIdle;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0xDD40")]
		public static readonly AnimationParameter State_clubHeavyAttack;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0xDD70")]
		public static readonly AnimationParameter State_ClubHeavyAttack;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0xDDA0")]
		public static readonly AnimationParameter State_ClubHeavyAttackWindup;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0xDDD0")]
		public static readonly AnimationParameter State_clubheavyAttackWindup;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0xDE00")]
		public static readonly AnimationParameter State_ClubParry;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0xDE30")]
		public static readonly AnimationParameter State_clubShove;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0xDE60")]
		public static readonly AnimationParameter State_coffinBoxIdle;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0xDE90")]
		public static readonly AnimationParameter State_CoffinBreakout;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0xDEC0")]
		public static readonly AnimationParameter State_CoffinIdle;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0xDEF0")]
		public static readonly AnimationParameter State_CoffinLighterHeldIdle;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0xDF20")]
		public static readonly AnimationParameter State_coffinOpen;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0xDF50")]
		public static readonly AnimationParameter State_coffinSequence;

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0xDF80")]
		public static readonly AnimationParameter State_CoffinToLIghterHeld;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0xDFB0")]
		public static readonly AnimationParameter State_CoinsACraftTimeBomb;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0xDFE0")]
		public static readonly AnimationParameter State_CoinsBCraftTimeBomb;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0xE010")]
		public static readonly AnimationParameter State_CoinsCCraftTimeBomb;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0xE040")]
		public static readonly AnimationParameter State_CoinsCraftLootPouch;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0xE070")]
		public static readonly AnimationParameter State_CoinsDCraftTimeBomb;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0xE0A0")]
		public static readonly AnimationParameter State_CoinsECraftTimeBomb;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0xE0D0")]
		public static readonly AnimationParameter State_CoinsIdle;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0xE100")]
		public static readonly AnimationParameter State_coldIdleVar1;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0xE130")]
		public static readonly AnimationParameter State_CombatKnifeCraftCraftedSpear;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0xE160")]
		public static readonly AnimationParameter State_CombatKnifeIdle;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0xE190")]
		public static readonly AnimationParameter State_ComboAttackA;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0xE1C0")]
		public static readonly AnimationParameter State_ComboAttackA180;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0xE1F0")]
		public static readonly AnimationParameter State_ComboAttackB;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0xE220")]
		public static readonly AnimationParameter State_ComboAttackB180;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0xE250")]
		public static readonly AnimationParameter State_ComboAttackC;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0xE280")]
		public static readonly AnimationParameter State_ComboAttackL;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0xE2B0")]
		public static readonly AnimationParameter State_ComboAttackR;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0xE2E0")]
		public static readonly AnimationParameter State_ComboEnderFromLeftB;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0xE310")]
		public static readonly AnimationParameter State_ComboEnderFromLeftBOnHit;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0xE340")]
		public static readonly AnimationParameter State_ComboEnderFromRightA;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0xE370")]
		public static readonly AnimationParameter State_ComboEnderFromRightAOnHit;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0xE3A0")]
		public static readonly AnimationParameter State_comboForward1;

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0xE3D0")]
		public static readonly AnimationParameter State_comboForward3;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0xE400")]
		public static readonly AnimationParameter State_CompactPistolCraftCompactPistolCompactPistolRail;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0xE430")]
		public static readonly AnimationParameter State_CompactPistolCraftCompactPistolFlashlightMod;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0xE460")]
		public static readonly AnimationParameter State_CompactPistolCraftCompactPistolLaserSightMod;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0xE490")]
		public static readonly AnimationParameter State_CompactPistolCraftCompactPistolPistolSuppressor;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0xE4C0")]
		public static readonly AnimationParameter State_CompactPistolCraftCompactPistolScopeMod;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0xE4F0")]
		public static readonly AnimationParameter State_CompactPistolIdle;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0xE520")]
		public static readonly AnimationParameter State_CompactPistolRailCraftCompactPistolCompactPistolRail;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0xE550")]
		public static readonly AnimationParameter State_CompactPistolRailIdle;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0xE580")]
		public static readonly AnimationParameter State_ContactTriggerIdle;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0xE5B0")]
		public static readonly AnimationParameter State_CookingInProgress;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0xE5E0")]
		public static readonly AnimationParameter State_couchIdle;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0xE610")]
		public static readonly AnimationParameter State_CowerLoop;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0xE640")]
		public static readonly AnimationParameter State_CowerToIdle;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0xE670")]
		public static readonly AnimationParameter State_CraftedArrowACraftCraftedArrows;

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0xE6A0")]
		public static readonly AnimationParameter State_CraftedArrowBCraftCraftedArrows;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0xE6D0")]
		public static readonly AnimationParameter State_CraftedArrowCCraftCraftedArrows;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0xE700")]
		public static readonly AnimationParameter State_CraftedArrowCraftCraftedArrows;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0xE730")]
		public static readonly AnimationParameter State_CraftedArrowDCraftCraftedArrows;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0xE760")]
		public static readonly AnimationParameter State_CraftedArrowIdle;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0xE790")]
		public static readonly AnimationParameter State_CraftedAxeCraftCraftedAxe;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0xE7C0")]
		public static readonly AnimationParameter State_CraftedAxeIdle;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0xE7F0")]
		public static readonly AnimationParameter State_CraftedBowCraftCraftedBow;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0xE820")]
		public static readonly AnimationParameter State_CraftedBowIdle;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0xE850")]
		public static readonly AnimationParameter State_CraftedClubCraftCraftedClub;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0xE880")]
		public static readonly AnimationParameter State_CraftedClubIdle;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0xE8B0")]
		public static readonly AnimationParameter State_CraftedSpearCraftCraftedSpear;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0xE8E0")]
		public static readonly AnimationParameter State_CraftedSpearIdle;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0xE910")]
		public static readonly AnimationParameter State_CraftingCogRotation;

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0xE940")]
		public static readonly AnimationParameter State_crash;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0xE970")]
		public static readonly AnimationParameter State_crashExtended;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0xE9A0")]
		public static readonly AnimationParameter State_crashRoll;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0xE9D0")]
		public static readonly AnimationParameter State_Crawl;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0xEA00")]
		public static readonly AnimationParameter State_CrawlBack;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0xEA30")]
		public static readonly AnimationParameter State_crawlForward;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0xEA60")]
		public static readonly AnimationParameter State_CrawlToIdle;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0xEA90")]
		public static readonly AnimationParameter State_CrawlUnderWall;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0xEAC0")]
		public static readonly AnimationParameter State_crossbowAimIdle;

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0xEAF0")]
		public static readonly AnimationParameter State_crossbowAimIdleEmpty;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0xEB20")]
		public static readonly AnimationParameter State_CrossbowCraftCrossbowFlashlightMod;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0xEB50")]
		public static readonly AnimationParameter State_CrossbowCraftCrossbowLaserSightMod;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0xEB80")]
		public static readonly AnimationParameter State_CrossbowCraftCrossbowScope;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0xEBB0")]
		public static readonly AnimationParameter State_crossbowFire;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0xEBE0")]
		public static readonly AnimationParameter State_crossbowFirstLook;

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0xEC10")]
		public static readonly AnimationParameter State_crossbowIdle;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0xEC40")]
		public static readonly AnimationParameter State_CrossbowIdle;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0xEC70")]
		public static readonly AnimationParameter State_crossbowIdleEmpty;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0xECA0")]
		public static readonly AnimationParameter State_crossbowIdleReload;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0xECD0")]
		public static readonly AnimationParameter State_crossbowReload;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0xED00")]
		public static readonly AnimationParameter State_crossbowReloadFromAim;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0xED30")]
		public static readonly AnimationParameter State_CrossEquip;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0xED60")]
		public static readonly AnimationParameter State_CrossFirstLook;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0xED90")]
		public static readonly AnimationParameter State_CrossIdle;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0xEDC0")]
		public static readonly AnimationParameter State_CrossScare;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0xEDF0")]
		public static readonly AnimationParameter State_CrossUnequip;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0xEE20")]
		public static readonly AnimationParameter State_Crouch_Walk;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0xEE50")]
		public static readonly AnimationParameter State_Crouch_Walk_Right;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0xEE80")]
		public static readonly AnimationParameter State_CrouchedIdle;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0xEEB0")]
		public static readonly AnimationParameter State_crouchedIdle1;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0xEEE0")]
		public static readonly AnimationParameter State_crouchedIdleToStanding;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0xEF10")]
		public static readonly AnimationParameter State_CrouchHiddenA;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0xEF40")]
		public static readonly AnimationParameter State_CrouchHiddenAToStand;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0xEF70")]
		public static readonly AnimationParameter State_Crouching;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0xEFA0")]
		public static readonly AnimationParameter State_CrouchToStand;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0xEFD0")]
		public static readonly AnimationParameter State_crouchWalk;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0xF000")]
		public static readonly AnimationParameter State_CutDWHit;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0xF030")]
		public static readonly AnimationParameter State_CutDWPrompt;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0xF060")]
		public static readonly AnimationParameter State_CutFloorHoleAxeChopAndPush;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0xF090")]
		public static readonly AnimationParameter State_CutPilarHit;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0xF0C0")]
		public static readonly AnimationParameter State_CutPilarHitToIdle;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0xF0F0")]
		public static readonly AnimationParameter State_CutPilarPrompt;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0xF120")]
		public static readonly AnimationParameter State_CutPilarPromptIdle;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0xF150")]
		public static readonly AnimationParameter State_CutPilarPromptIntro;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0xF180")]
		public static readonly AnimationParameter State_CutPilarSwing;

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0xF1B0")]
		public static readonly AnimationParameter State_CutQuarterOffOnGroundAxeAttack;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0xF1E0")]
		public static readonly AnimationParameter State_Cutscene;

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0xF210")]
		public static readonly AnimationParameter State_CutShelfNotch;

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0xF240")]
		public static readonly AnimationParameter State_CutWindowAxeChopAndPush;

		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0xF270")]
		public static readonly AnimationParameter State_DanceCasual;

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0xF2A0")]
		public static readonly AnimationParameter State_DanceCasualToIdle;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0xF2D0")]
		public static readonly AnimationParameter State_DanceTree;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0xF300")]
		public static readonly AnimationParameter State_deadIdle;

		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0xF330")]
		public static readonly AnimationParameter State_deadToHeldIdle;

		// Token: 0x04000629 RID: 1577
		[Token(Token = "0x4000629")]
		[FieldOffset(Offset = "0xF360")]
		public static readonly AnimationParameter State_Death;

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0xF390")]
		public static readonly AnimationParameter State_deathFallBack;

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0xF3C0")]
		public static readonly AnimationParameter State_deathFallForward;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0xF3F0")]
		public static readonly AnimationParameter State_deathFallForwardA;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0xF420")]
		public static readonly AnimationParameter State_deathFallForwardC;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0xF450")]
		public static readonly AnimationParameter State_deathFallShort;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0xF480")]
		public static readonly AnimationParameter State_DeathHeadHitFallBackB;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0xF4B0")]
		public static readonly AnimationParameter State_DeathHitFallForward;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0xF4E0")]
		public static readonly AnimationParameter State_DeathOnBack;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0xF510")]
		public static readonly AnimationParameter State_DeathOnStomach;

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0xF540")]
		public static readonly AnimationParameter State_deathStealth1;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0xF570")]
		public static readonly AnimationParameter State_DeathVariation1;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0xF5A0")]
		public static readonly AnimationParameter State_DeathVariationSmallerBodyOnTop;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0xF5D0")]
		public static readonly AnimationParameter State_DeerDeathCycle;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0xF600")]
		public static readonly AnimationParameter State_DeerElectrocuted;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0xF630")]
		public static readonly AnimationParameter State_DeerElectrocutedFall;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0xF660")]
		public static readonly AnimationParameter State_DeerHideACraftDeerHideArmour;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0xF690")]
		public static readonly AnimationParameter State_DeerHideArmourCraftDeerHideArmour;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0xF6C0")]
		public static readonly AnimationParameter State_DeerHideArmourIdle;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0xF6F0")]
		public static readonly AnimationParameter State_DeerHideBCraftDeerHideArmour;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0xF720")]
		public static readonly AnimationParameter State_DeerHideIdle;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0xF750")]
		public static readonly AnimationParameter State_DeerHit;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0xF780")]
		public static readonly AnimationParameter State_DeerRecover;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0xF7B0")]
		public static readonly AnimationParameter State_DefaultPassThrough;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0xF7E0")]
		public static readonly AnimationParameter State_DemonBossAttackA;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0xF810")]
		public static readonly AnimationParameter State_DemonBossAttackALeftArm;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0xF840")]
		public static readonly AnimationParameter State_DemonBossAttackARightArm;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0xF870")]
		public static readonly AnimationParameter State_DemonBossAttackB;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0xF8A0")]
		public static readonly AnimationParameter State_DemonBossIntro;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0xF8D0")]
		public static readonly AnimationParameter State_DenyEntry;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0xF900")]
		public static readonly AnimationParameter State_DevilsClubCraftHerbMix;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0xF930")]
		public static readonly AnimationParameter State_DevilsClubIdle;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0xF960")]
		public static readonly AnimationParameter State_Dialog;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0xF990")]
		public static readonly AnimationParameter State_Die;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0xF9C0")]
		public static readonly AnimationParameter State_Die_Backwards;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0xF9F0")]
		public static readonly AnimationParameter State_digToShovelIdleOld;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0xFA20")]
		public static readonly AnimationParameter State_dirtChunkDig;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0xFA50")]
		public static readonly AnimationParameter State_Disabled;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0xFA80")]
		public static readonly AnimationParameter State_DismantleCog;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0xFAB0")]
		public static readonly AnimationParameter State_DismemberDeath;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0xFAE0")]
		public static readonly AnimationParameter State_DismemberDeathFromStomach;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0xFB10")]
		public static readonly AnimationParameter State_DismemberLeftArm;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0xFB40")]
		public static readonly AnimationParameter State_DismemberLeftArmFromStomach;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0xFB70")]
		public static readonly AnimationParameter State_DismemberLeftLeg;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0xFBA0")]
		public static readonly AnimationParameter State_DismemberLeftLegFromStomach;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0xFBD0")]
		public static readonly AnimationParameter State_DismemberRightArm;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0xFC00")]
		public static readonly AnimationParameter State_DismemberRightArmFromStomach;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0xFC30")]
		public static readonly AnimationParameter State_DismemberRightLeg;

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0xFC60")]
		public static readonly AnimationParameter State_DismemberRightLegFromStomach;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0xFC90")]
		public static readonly AnimationParameter State_DistantYell;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0xFCC0")]
		public static readonly AnimationParameter State_DistantYellLong;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0xFCF0")]
		public static readonly AnimationParameter State_DistantYellShort;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0xFD20")]
		public static readonly AnimationParameter State_dodgeBack;

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0xFD50")]
		public static readonly AnimationParameter State_DodgeBackA;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0xFD80")]
		public static readonly AnimationParameter State_DodgeBackB;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0xFDB0")]
		public static readonly AnimationParameter State_DodgeBackToCounterA;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0xFDE0")]
		public static readonly AnimationParameter State_DodgeBackToCounterB;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0xFE10")]
		public static readonly AnimationParameter State_DodgeBackToCounterC;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0xFE40")]
		public static readonly AnimationParameter State_DodgeBackwardsFromAttack;

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0xFE70")]
		public static readonly AnimationParameter State_DodgeCounterC;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0xFEA0")]
		public static readonly AnimationParameter State_DodgeLeft;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0xFED0")]
		public static readonly AnimationParameter State_DodgeLeftA;

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0xFF00")]
		public static readonly AnimationParameter State_DodgeLeftRoll;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0xFF30")]
		public static readonly AnimationParameter State_DodgeLeftToCounterA_;

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0xFF60")]
		public static readonly AnimationParameter State_DodgeLeftToCounterB;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0xFF90")]
		public static readonly AnimationParameter State_DodgeRight;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0xFFC0")]
		public static readonly AnimationParameter State_DodgeRightA;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0xFFF0")]
		public static readonly AnimationParameter State_DodgeRightRoll;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x10020")]
		public static readonly AnimationParameter State_DodgeRightToCounterA;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x10050")]
		public static readonly AnimationParameter State_DodgeRightToCounterB;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x10080")]
		public static readonly AnimationParameter State_DoorKnock;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x100B0")]
		public static readonly AnimationParameter State_DragAllyAway;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x100E0")]
		public static readonly AnimationParameter State_DragAllyAwayIntro;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x10110")]
		public static readonly AnimationParameter State_DragAllyAwayOutro;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x10140")]
		public static readonly AnimationParameter State_dragAway;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x10170")]
		public static readonly AnimationParameter State_DragAway;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x101A0")]
		public static readonly AnimationParameter State_DragAwayToIdle;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x101D0")]
		public static readonly AnimationParameter State_DragCycle;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x10200")]
		public static readonly AnimationParameter State_DraggedAway;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x10230")]
		public static readonly AnimationParameter State_DraggedAwayIntro;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x10260")]
		public static readonly AnimationParameter State_DraggedAwayOutro;

		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x10290")]
		public static readonly AnimationParameter State_drawBow;

		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x102C0")]
		public static readonly AnimationParameter State_drawBowEmpty;

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x102F0")]
		public static readonly AnimationParameter State_drawBowIdle;

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x10320")]
		public static readonly AnimationParameter State_drawBowIdleEmpty;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x10350")]
		public static readonly AnimationParameter State_drawPistolForward;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x10380")]
		public static readonly AnimationParameter State_drawPistolLeft;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x103B0")]
		public static readonly AnimationParameter State_drawPistolRight;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0x103E0")]
		public static readonly AnimationParameter State_drawTacticalBow;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x10410")]
		public static readonly AnimationParameter State_drawTacticalBowEmpty;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x10440")]
		public static readonly AnimationParameter State_drawTacticalBowIdle;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x10470")]
		public static readonly AnimationParameter State_drawTacticalBowIdleEmpty;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x104A0")]
		public static readonly AnimationParameter State_Drink;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x104D0")]
		public static readonly AnimationParameter State_DrinkA;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x10500")]
		public static readonly AnimationParameter State_DrinkAtPond;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x10530")]
		public static readonly AnimationParameter State_drinkAtPond;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x10560")]
		public static readonly AnimationParameter State_DrinkB;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x10590")]
		public static readonly AnimationParameter State_DrinkBloodTroughA;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x105C0")]
		public static readonly AnimationParameter State_DrinkBloodTroughB;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x105F0")]
		public static readonly AnimationParameter State_DrinkBloodTroughHangingA;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x10620")]
		public static readonly AnimationParameter State_DrinkBloodTroughHangingB;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x10650")]
		public static readonly AnimationParameter State_DrinkFlask;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x10680")]
		public static readonly AnimationParameter State_DrinkFromPond;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x106B0")]
		public static readonly AnimationParameter State_DrinkFromPot;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x106E0")]
		public static readonly AnimationParameter State_DrinkFromStream;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x10710")]
		public static readonly AnimationParameter State_drinkFromStream;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x10740")]
		public static readonly AnimationParameter State_DrinkLoop;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x10770")]
		public static readonly AnimationParameter State_DrinkSoda;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x107A0")]
		public static readonly AnimationParameter State_drinkSoda;

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[FieldOffset(Offset = "0x107D0")]
		public static readonly AnimationParameter State_DrinkToIdle;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x10800")]
		public static readonly AnimationParameter State_DroneControllerIdle;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x10830")]
		public static readonly AnimationParameter State_dropBody;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x10860")]
		public static readonly AnimationParameter State_Dropdown_In;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x10890")]
		public static readonly AnimationParameter State_Dropdown_Out;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x108C0")]
		public static readonly AnimationParameter State_DropFish;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x108F0")]
		public static readonly AnimationParameter State_DropFromCeilingFall;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x10920")]
		public static readonly AnimationParameter State_DropFromCeilingIdle;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[FieldOffset(Offset = "0x10950")]
		public static readonly AnimationParameter State_DropFromCeilingIntro;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		[FieldOffset(Offset = "0x10980")]
		public static readonly AnimationParameter State_DropFromCeilingLand;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[FieldOffset(Offset = "0x109B0")]
		public static readonly AnimationParameter State_DropFromCeilingToIdle;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x109E0")]
		public static readonly AnimationParameter State_DropHelicopter;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x10A10")]
		public static readonly AnimationParameter State_DropItem;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x10A40")]
		public static readonly AnimationParameter State_DropLog;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x10A70")]
		public static readonly AnimationParameter State_DropRadio;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x10AA0")]
		public static readonly AnimationParameter State_DropRock;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x10AD0")]
		public static readonly AnimationParameter State_DropStick;

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x10B00")]
		public static readonly AnimationParameter State_Drowning;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x10B30")]
		public static readonly AnimationParameter State_drowningOnBack;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x10B60")]
		public static readonly AnimationParameter State_drunkenAction1;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x10B90")]
		public static readonly AnimationParameter State_drunkenAction2;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x10BC0")]
		public static readonly AnimationParameter State_dryFireBow;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x10BF0")]
		public static readonly AnimationParameter State_dryFireTacticalBow;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x10C20")]
		public static readonly AnimationParameter State_DuckDeath;

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0x10C50")]
		public static readonly AnimationParameter State_DuckDrinking;

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x10C80")]
		public static readonly AnimationParameter State_DuckEating;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x10CB0")]
		public static readonly AnimationParameter State_DuckEatOnLand;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x10CE0")]
		public static readonly AnimationParameter State_DuckLandOnLand;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x10D10")]
		public static readonly AnimationParameter State_DuckSitOnLand;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x10D40")]
		public static readonly AnimationParameter State_DuckTakeOffFromLand;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x10D70")]
		public static readonly AnimationParameter State_DuckTempIdle;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x10DA0")]
		public static readonly AnimationParameter State_DuckWalkOnLand;

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x10DD0")]
		public static readonly AnimationParameter State_DuctTapeCraftBoneArmor;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x10E00")]
		public static readonly AnimationParameter State_DuctTapeCraftCraftedBow;

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x10E30")]
		public static readonly AnimationParameter State_DuctTapeCraftCraftedSpear;

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x10E60")]
		public static readonly AnimationParameter State_DuctTapeCraftLootPouch;

		// Token: 0x040006BA RID: 1722
		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x10E90")]
		public static readonly AnimationParameter State_DuctTapeCraftTechArmor;

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x10EC0")]
		public static readonly AnimationParameter State_DuctTapeCraftTimeBomb;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x10EF0")]
		public static readonly AnimationParameter State_DuctTapeIdle;

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x10F20")]
		public static readonly AnimationParameter State_dyingNoLegs;

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x10F50")]
		public static readonly AnimationParameter State_EagleDeath;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x10F80")]
		public static readonly AnimationParameter State_EagleSwoopPickUp;

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x10FB0")]
		public static readonly AnimationParameter State_eat;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0x10FE0")]
		public static readonly AnimationParameter State_Eat;

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x11010")]
		public static readonly AnimationParameter State_EatArm;

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		[FieldOffset(Offset = "0x11040")]
		public static readonly AnimationParameter State_EatBerryA;

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0x11070")]
		public static readonly AnimationParameter State_EatBerryB;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0x110A0")]
		public static readonly AnimationParameter State_EatBerryC;

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0x110D0")]
		public static readonly AnimationParameter State_EatCereal;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0x11100")]
		public static readonly AnimationParameter State_EatDeadBody;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0x11130")]
		public static readonly AnimationParameter State_EatDeadBodyToIdle;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x11160")]
		public static readonly AnimationParameter State_EatEnergyBar;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x11190")]
		public static readonly AnimationParameter State_EatFish;

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x111C0")]
		public static readonly AnimationParameter State_EatGround;

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x111F0")]
		public static readonly AnimationParameter State_EatHerbA;

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x11220")]
		public static readonly AnimationParameter State_EatHerbB;

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x11250")]
		public static readonly AnimationParameter State_EatLeg;

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		[FieldOffset(Offset = "0x11280")]
		public static readonly AnimationParameter State_EatLoop;

		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		[FieldOffset(Offset = "0x112B0")]
		public static readonly AnimationParameter State_EatMeat;

		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		[FieldOffset(Offset = "0x112E0")]
		public static readonly AnimationParameter State_eatMeat;

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x11310")]
		public static readonly AnimationParameter State_EatMeat01;

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0x11340")]
		public static readonly AnimationParameter State_eatMeatCycle;

		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x11370")]
		public static readonly AnimationParameter State_EatMeatGround;

		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x40006D5")]
		[FieldOffset(Offset = "0x113A0")]
		public static readonly AnimationParameter State_EatMeatGroundToIdle;

		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x113D0")]
		public static readonly AnimationParameter State_eatMeds;

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x11400")]
		public static readonly AnimationParameter State_EatMeds;

		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		[FieldOffset(Offset = "0x11430")]
		public static readonly AnimationParameter State_EatMre;

		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		[FieldOffset(Offset = "0x11460")]
		public static readonly AnimationParameter State_eatMre;

		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x40006DA")]
		[FieldOffset(Offset = "0x11490")]
		public static readonly AnimationParameter State_EatMushroom;

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		[FieldOffset(Offset = "0x114C0")]
		public static readonly AnimationParameter State_EatOyster;

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		[FieldOffset(Offset = "0x114F0")]
		public static readonly AnimationParameter State_EatRamen;

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0x11520")]
		public static readonly AnimationParameter State_EatToIdle;

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0x11550")]
		public static readonly AnimationParameter State_Electrocuted;

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0x11580")]
		public static readonly AnimationParameter State_ElectrocutedC;

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0x115B0")]
		public static readonly AnimationParameter State_ElectrocutedDeathTemp;

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x115E0")]
		public static readonly AnimationParameter State_ElectrocuteOnBackStandup;

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x11610")]
		public static readonly AnimationParameter State_ElectrocuteOnStomachStandup;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x11640")]
		public static readonly AnimationParameter State_Eletrocuted;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x11670")]
		public static readonly AnimationParameter State_EmailPageEquip;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x116A0")]
		public static readonly AnimationParameter State_EmailPageIdle;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x116D0")]
		public static readonly AnimationParameter State_EmailPageIdleToRead;

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x11700")]
		public static readonly AnimationParameter State_EmailPageRead;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x11730")]
		public static readonly AnimationParameter State_EmailPageReadToIdle;

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x11760")]
		public static readonly AnimationParameter State_EmailPageUnequip;

		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x40006EA")]
		[FieldOffset(Offset = "0x11790")]
		public static readonly AnimationParameter State_Embryotic;

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0x117C0")]
		public static readonly AnimationParameter State_EmergencyPackCraftEmptyBag;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x117F0")]
		public static readonly AnimationParameter State_EmergencyPackIdle;

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		[FieldOffset(Offset = "0x11820")]
		public static readonly AnimationParameter State_Empty;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x11850")]
		public static readonly AnimationParameter State_EmptyStart;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x11880")]
		public static readonly AnimationParameter State_EndCutscene;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x118B0")]
		public static readonly AnimationParameter State_EnergyBarCraftLootPouch;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x118E0")]
		public static readonly AnimationParameter State_EnergyBarIdle;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x11910")]
		public static readonly AnimationParameter State_EnergyDrinkCraftLootPouch;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x11940")]
		public static readonly AnimationParameter State_EnergyDrinkIdle;

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x11970")]
		public static readonly AnimationParameter State_EnergyMixCraftHerbMix;

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x119A0")]
		public static readonly AnimationParameter State_EnergyMixIdle;

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x119D0")]
		public static readonly AnimationParameter State_EnergyMixPlusCraftHerbMix;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x11A00")]
		public static readonly AnimationParameter State_EnergyMixPlusIdle;

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x11A30")]
		public static readonly AnimationParameter State_enterCave1;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x11A60")]
		public static readonly AnimationParameter State_EnterDoor;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x11A90")]
		public static readonly AnimationParameter State_EnterHatch;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x11AC0")]
		public static readonly AnimationParameter State_equipClub;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x11AF0")]
		public static readonly AnimationParameter State_EquipClub;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x11B20")]
		public static readonly AnimationParameter State_equipKnife;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x11B50")]
		public static readonly AnimationParameter State_EquipRepairTool;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x11B80")]
		public static readonly AnimationParameter State_equipStick;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x11BB0")]
		public static readonly AnimationParameter State_equipTacticalAxe;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x11BE0")]
		public static readonly AnimationParameter State_ExamineBodyA;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x11C10")]
		public static readonly AnimationParameter State_exitCave;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x11C40")]
		public static readonly AnimationParameter State_ExitHatch;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x11C70")]
		public static readonly AnimationParameter State_ExitHatchToStanding;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x11CA0")]
		public static readonly AnimationParameter State_ExplodeBoatEngine;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x11CD0")]
		public static readonly AnimationParameter State_explodeShake;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x11D00")]
		public static readonly AnimationParameter State_EyeOverride;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x11D30")]
		public static readonly AnimationParameter State_Fade_In;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x11D60")]
		public static readonly AnimationParameter State_Fade_Out;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x11D90")]
		public static readonly AnimationParameter State_FadeIn;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x11DC0")]
		public static readonly AnimationParameter State_FallBackDeath;

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x11DF0")]
		public static readonly AnimationParameter State_FallDownBack;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x11E20")]
		public static readonly AnimationParameter State_FallDownBackCrouched;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x11E50")]
		public static readonly AnimationParameter State_FallDownBackCrouchedDead;

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x11E80")]
		public static readonly AnimationParameter State_fallExplosion;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x11EB0")]
		public static readonly AnimationParameter State_FallForwardDeath;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x11EE0")]
		public static readonly AnimationParameter State_FallIdle;

		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x11F10")]
		public static readonly AnimationParameter State_FallIdleArmed;

		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0x11F40")]
		public static readonly AnimationParameter State_FanAnimation;

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x11F70")]
		public static readonly AnimationParameter State_FastCrawl;

		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x11FA0")]
		public static readonly AnimationParameter State_FastCrawlToIdle;

		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0x11FD0")]
		public static readonly AnimationParameter State_FeatherACraftCraftedArrows;

		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0x12000")]
		public static readonly AnimationParameter State_FeatherBCraftCraftedArrows;

		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		[FieldOffset(Offset = "0x12030")]
		public static readonly AnimationParameter State_FeatherCraftLootPouch;

		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		[FieldOffset(Offset = "0x12060")]
		public static readonly AnimationParameter State_FeatherIdle;

		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		[FieldOffset(Offset = "0x12090")]
		public static readonly AnimationParameter State_feeding1;

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x120C0")]
		public static readonly AnimationParameter State_FemaleCannibalTreeTaunt;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x120F0")]
		public static readonly AnimationParameter State_fillPot;

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x12120")]
		public static readonly AnimationParameter State_fillWaterSkin;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x12150")]
		public static readonly AnimationParameter State_FingersAgitatedCapturedIdle;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x12180")]
		public static readonly AnimationParameter State_FingersCapturedIdle;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x121B0")]
		public static readonly AnimationParameter State_Finish;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x121E0")]
		public static readonly AnimationParameter State_Finished;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x12210")]
		public static readonly AnimationParameter State_FinishedCooking;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x12240")]
		public static readonly AnimationParameter State_FireweedCraftHerbMix;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x12270")]
		public static readonly AnimationParameter State_FireweedIdle;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x122A0")]
		public static readonly AnimationParameter State_FirstDanceForPlayer;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x122D0")]
		public static readonly AnimationParameter State_FirstTime;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x12300")]
		public static readonly AnimationParameter State_flameThrowerAttack;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x12330")]
		public static readonly AnimationParameter State_flameThrowerIdle;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x12360")]
		public static readonly AnimationParameter State_FlapForward;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x12390")]
		public static readonly AnimationParameter State_FlapToGlide;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x123C0")]
		public static readonly AnimationParameter State_flareGunAimShoot;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x123F0")]
		public static readonly AnimationParameter State_flareGunIdle;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x12420")]
		public static readonly AnimationParameter State_flareGunIdle_0;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x12450")]
		public static readonly AnimationParameter State_flaregunReload;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x12480")]
		public static readonly AnimationParameter State_flaregunShoot;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x124B0")]
		public static readonly AnimationParameter State_flareIdle;

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0x124E0")]
		public static readonly AnimationParameter State_flareLight;

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x12510")]
		public static readonly AnimationParameter State_flareLighterIgnite;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x12540")]
		public static readonly AnimationParameter State_FlashlightEmailHeldIdle;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x12570")]
		public static readonly AnimationParameter State_FlashlightEmailReadIlde;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x125A0")]
		public static readonly AnimationParameter State_flashlightIdle;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x125D0")]
		public static readonly AnimationParameter State_FlashlightIdle;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x12600")]
		public static readonly AnimationParameter State_flashLightIdle;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x12630")]
		public static readonly AnimationParameter State_flashlightIdleCrouch;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x12660")]
		public static readonly AnimationParameter State_flashlightIdleHeld;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x12690")]
		public static readonly AnimationParameter State_flashlightIdleHeldCrouch;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x126C0")]
		public static readonly AnimationParameter State_FlashlightIdleHeldGliderFly;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x126F0")]
		public static readonly AnimationParameter State_flashlightIdleHeldRifle;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x12720")]
		public static readonly AnimationParameter State_flashlightIdleWide;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x12750")]
		public static readonly AnimationParameter State_FlashlightModCraftCompactPistolFlashlightMod;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x12780")]
		public static readonly AnimationParameter State_FlashlightModCraftCrossbowFlashlightMod;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x127B0")]
		public static readonly AnimationParameter State_FlashlightModCraftShotgunPumpActionFlashlightMod;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x127E0")]
		public static readonly AnimationParameter State_FlashlightModIdle;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x12810")]
		public static readonly AnimationParameter State_flashlightSlideDown;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x12840")]
		public static readonly AnimationParameter State_FlaskFillUp;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x12870")]
		public static readonly AnimationParameter State_FlaskIdle;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x128A0")]
		public static readonly AnimationParameter State_FlingAttack;

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x128D0")]
		public static readonly AnimationParameter State_flintlockIdle;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x12900")]
		public static readonly AnimationParameter State_flopDying;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x12930")]
		public static readonly AnimationParameter State_Fly;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x12960")]
		public static readonly AnimationParameter State_FlyFoldedWings;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x12990")]
		public static readonly AnimationParameter State_flyingAxeAttack;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x129C0")]
		public static readonly AnimationParameter State_flyingLoop;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x129F0")]
		public static readonly AnimationParameter State_flyingRockAttack;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x12A20")]
		public static readonly AnimationParameter State_FlySwatterResetTrap;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x12A50")]
		public static readonly AnimationParameter State_FlySwatterTriggerTrap;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x12A80")]
		public static readonly AnimationParameter State_FlyThroughClouds;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x12AB0")]
		public static readonly AnimationParameter State_FoodTrayCraftFoodTrayFilled;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x12AE0")]
		public static readonly AnimationParameter State_FoodTrayFilledCraftFoodTrayFilled;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0x12B10")]
		public static readonly AnimationParameter State_FoodTrayFilledIdle;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x12B40")]
		public static readonly AnimationParameter State_FoodTrayIdle;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x12B70")]
		public static readonly AnimationParameter State_forward_0;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x12BA0")]
		public static readonly AnimationParameter State_FrogIdle;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x12BD0")]
		public static readonly AnimationParameter State_frontSeatsFly;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x12C00")]
		public static readonly AnimationParameter State_FullbodyTaunt04;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x12C30")]
		public static readonly AnimationParameter State_FullbodyTauntA;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x12C60")]
		public static readonly AnimationParameter State_FullbodyTauntB;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x12C90")]
		public static readonly AnimationParameter State_FullbodyTauntBigA;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x12CC0")]
		public static readonly AnimationParameter State_FullbodyTauntBigB;

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		[FieldOffset(Offset = "0x12CF0")]
		public static readonly AnimationParameter State_FullBodyTauntC;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x12D20")]
		public static readonly AnimationParameter State_FullbodyTauntMedium02;

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x12D50")]
		public static readonly AnimationParameter State_FullbodyTauntScream01;

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x12D80")]
		public static readonly AnimationParameter State_FullbodyTauntSmall01;

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x12DB0")]
		public static readonly AnimationParameter State_FullbodyTauntSmall03;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x12DE0")]
		public static readonly AnimationParameter State_Gallop;

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x12E10")]
		public static readonly AnimationParameter State_gallop_loop;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x12E40")]
		public static readonly AnimationParameter State_GallopToIdle;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x12E70")]
		public static readonly AnimationParameter State_GatherBerriesA;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x12EA0")]
		public static readonly AnimationParameter State_GatherBerriesB;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x12ED0")]
		public static readonly AnimationParameter State_genericAttack1;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x12F00")]
		public static readonly AnimationParameter State_genericAttackWide;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x12F30")]
		public static readonly AnimationParameter State_genericHoldIdle;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x12F60")]
		public static readonly AnimationParameter State_Get_Up_Prone;

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x12F90")]
		public static readonly AnimationParameter State_GetDownSonCutscene;

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x12FC0")]
		public static readonly AnimationParameter State_GetDownSonWakeupCutscene;

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x12FF0")]
		public static readonly AnimationParameter State_GetHit;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x13020")]
		public static readonly AnimationParameter State_GetHitBack;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x13050")]
		public static readonly AnimationParameter State_GetHitFront;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x13080")]
		public static readonly AnimationParameter State_GetHitLeft;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x130B0")]
		public static readonly AnimationParameter State_GetHitRight;

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x130E0")]
		public static readonly AnimationParameter State_GetToTheChopperCutscene;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x13110")]
		public static readonly AnimationParameter State_Getup;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x13140")]
		public static readonly AnimationParameter State_GetUp;

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x13170")]
		public static readonly AnimationParameter State_GetUpBackA;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x131A0")]
		public static readonly AnimationParameter State_GetUpBackB;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x131D0")]
		public static readonly AnimationParameter State_GetUpStomachA;

		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x13200")]
		public static readonly AnimationParameter State_girlPickupIdle;

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x13230")]
		public static readonly AnimationParameter State_girlToMachine;

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x13260")]
		public static readonly AnimationParameter State_girlTransformReaction;

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x13290")]
		public static readonly AnimationParameter State_GlideForward;

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x132C0")]
		public static readonly AnimationParameter State_GlideLandBranch;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x132F0")]
		public static readonly AnimationParameter State_GlideLandGround;

		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x13320")]
		public static readonly AnimationParameter State_GlideLoop;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x13350")]
		public static readonly AnimationParameter State_GliderFlyIdle;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x13380")]
		public static readonly AnimationParameter State_gliderFlyingForward;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x133B0")]
		public static readonly AnimationParameter State_GliderIdleFolded;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x133E0")]
		public static readonly AnimationParameter State_gliderIdleGrounded;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x13410")]
		public static readonly AnimationParameter State_GliderIdleOpen;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x13440")]
		public static readonly AnimationParameter State_GliderJump;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x13470")]
		public static readonly AnimationParameter State_GliderLand;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x134A0")]
		public static readonly AnimationParameter State_GliderLeanLeft;

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x134D0")]
		public static readonly AnimationParameter State_GliderLeanRight;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x13500")]
		public static readonly AnimationParameter State_GliderStandingIdle;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x13530")]
		public static readonly AnimationParameter State_GlideToFlap;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x13560")]
		public static readonly AnimationParameter State_GoldDoorCutscene;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x13590")]
		public static readonly AnimationParameter State_GoldRoomCutscene;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x135C0")]
		public static readonly AnimationParameter State_GoldRoomVirginiaMissing;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x135F0")]
		public static readonly AnimationParameter State_GolfPutterGroundStart;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x13620")]
		public static readonly AnimationParameter State_GolfPutterPutt;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x13650")]
		public static readonly AnimationParameter State_GolfPutterSwing;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x13680")]
		public static readonly AnimationParameter State_goodbyeTimmy;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x136B0")]
		public static readonly AnimationParameter State_GPSTrackerCraftEmptyBag;

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x136E0")]
		public static readonly AnimationParameter State_GPSTrackerIdle;

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x13710")]
		public static readonly AnimationParameter State_GrabBagEquip;

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x13740")]
		public static readonly AnimationParameter State_GrabBagIdle;

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x13770")]
		public static readonly AnimationParameter State_GrabBagSwipeA;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x137A0")]
		public static readonly AnimationParameter State_GrabBagSwipeB;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x137D0")]
		public static readonly AnimationParameter State_GrabBagSwipeC;

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x13800")]
		public static readonly AnimationParameter State_GrabBagUnequip;

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x13830")]
		public static readonly AnimationParameter State_Grabbed;

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x13860")]
		public static readonly AnimationParameter State_GrenadeHeldIdle;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x13890")]
		public static readonly AnimationParameter State_GrenadeHeldToIdle;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x138C0")]
		public static readonly AnimationParameter State_GrenadeIdleToHeld;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x138F0")]
		public static readonly AnimationParameter State_GrenadePrimedIdle;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x13920")]
		public static readonly AnimationParameter State_GrenadeThrow;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x13950")]
		public static readonly AnimationParameter State_Grounded_Directional;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x13980")]
		public static readonly AnimationParameter State_Grounded_Strafe;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x139B0")]
		public static readonly AnimationParameter State_GuitarEquip;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x139E0")]
		public static readonly AnimationParameter State_GuitarFirstLook;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x13A10")]
		public static readonly AnimationParameter State_GuitarIdleToPlay;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x13A40")]
		public static readonly AnimationParameter State_GuitarRiffHeyYou;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x13A70")]
		public static readonly AnimationParameter State_GuitarRiffRandomThings;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x13AA0")]
		public static readonly AnimationParameter State_GuitarRiffTheme1;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x13AD0")]
		public static readonly AnimationParameter State_GuitarRiffTheme2;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x13B00")]
		public static readonly AnimationParameter State_GuitarRiffTrailer;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x13B30")]
		public static readonly AnimationParameter State_GuitarRiffWanky;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x13B60")]
		public static readonly AnimationParameter State_GunCaseClose;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x13B90")]
		public static readonly AnimationParameter State_GunCaseClosedIdle;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x13BC0")]
		public static readonly AnimationParameter State_GunCaseOpen;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x13BF0")]
		public static readonly AnimationParameter State_GunCaseOpenIdle;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x13C20")]
		public static readonly AnimationParameter State_Hammer;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x13C50")]
		public static readonly AnimationParameter State_hangingAttack;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x13C80")]
		public static readonly AnimationParameter State_hangingAxeAttack;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x13CB0")]
		public static readonly AnimationParameter State_hangingDropToIdle;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x13CE0")]
		public static readonly AnimationParameter State_hangingHeadLook;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x13D10")]
		public static readonly AnimationParameter State_hangingHeadUpIdle;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x13D40")]
		public static readonly AnimationParameter State_hangingIdle;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x13D70")]
		public static readonly AnimationParameter State_Hatch;

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x13DA0")]
		public static readonly AnimationParameter State_HeadDownToIdle;

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x13DD0")]
		public static readonly AnimationParameter State_HealthMixCraftHerbMix;

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x13E00")]
		public static readonly AnimationParameter State_HealthMixIdle;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x13E30")]
		public static readonly AnimationParameter State_HealthMixPlusCraftHerbMix;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x13E60")]
		public static readonly AnimationParameter State_HealthMixPlusIdle;

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0x13E90")]
		public static readonly AnimationParameter State_HeavyAxeAttackToLeftA;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0x13EC0")]
		public static readonly AnimationParameter State_HeavyAxeAttackToRightA;

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0x13EF0")]
		public static readonly AnimationParameter State_HeavyAxeBlock1;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x13F20")]
		public static readonly AnimationParameter State_HeavyAxeBlockedLeftA;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x13F50")]
		public static readonly AnimationParameter State_HeavyAxeBlockedRightA;

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x13F80")]
		public static readonly AnimationParameter State_HeavyAxeBlockHit1;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x13FB0")]
		public static readonly AnimationParameter State_HeavyAxeBlockToIdle;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x13FE0")]
		public static readonly AnimationParameter State_HeavyAxeParry;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x14010")]
		public static readonly AnimationParameter State_HeavyBreathingToIdle;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x14040")]
		public static readonly AnimationParameter State_HeavyTaserStickAttack;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x14070")]
		public static readonly AnimationParameter State_HeavyTaserStickAttackWindup;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x140A0")]
		public static readonly AnimationParameter State_heldIdle_0;

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x140D0")]
		public static readonly AnimationParameter State_heldIdleToDead;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x14100")]
		public static readonly AnimationParameter State_HelicopterAttackBehindLeft;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x14130")]
		public static readonly AnimationParameter State_HelicopterAttackBehindRight;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x14160")]
		public static readonly AnimationParameter State_HelicopterAttackLeft;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x14190")]
		public static readonly AnimationParameter State_HelicopterAttackRight;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x141C0")]
		public static readonly AnimationParameter State_HelicopterAttackSlamForward;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x141F0")]
		public static readonly AnimationParameter State_HelicopterAttackSwipeLeft;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x14220")]
		public static readonly AnimationParameter State_HelicopterAttackSwipeRight;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x14250")]
		public static readonly AnimationParameter State_HelicopterAttackThrowA;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x14280")]
		public static readonly AnimationParameter State_HelicopterIdle;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x142B0")]
		public static readonly AnimationParameter State_HelicopterPickup;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x142E0")]
		public static readonly AnimationParameter State_helicopterTreeCrashSequence;

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x14310")]
		public static readonly AnimationParameter State_HelicopterWalk;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x14340")]
		public static readonly AnimationParameter State_hidden;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x14370")]
		public static readonly AnimationParameter State_HiddenInLeaves;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x143A0")]
		public static readonly AnimationParameter State_HiddenIntroLeft;

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x143D0")]
		public static readonly AnimationParameter State_HiddenIntroRight;

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x14400")]
		public static readonly AnimationParameter State_hide;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x14430")]
		public static readonly AnimationParameter State_HideInShellPose;

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x14460")]
		public static readonly AnimationParameter State_HideInShellToIdle;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x14490")]
		public static readonly AnimationParameter State_HideLoop;

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x144C0")]
		public static readonly AnimationParameter State_HideToIdle;

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x144F0")]
		public static readonly AnimationParameter State_Highlighted;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x14520")]
		public static readonly AnimationParameter State_HighlightedToNormal;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x14550")]
		public static readonly AnimationParameter State_HitAdditiveA;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x14580")]
		public static readonly AnimationParameter State_HitAdditiveB;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x145B0")]
		public static readonly AnimationParameter State_HitAdditiveBackA;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x145E0")]
		public static readonly AnimationParameter State_HitAdditiveBackB;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x14610")]
		public static readonly AnimationParameter State_HitAdditiveBackC;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x14640")]
		public static readonly AnimationParameter State_HitAdditiveBigA;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x14670")]
		public static readonly AnimationParameter State_HitAdditiveBigB;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x146A0")]
		public static readonly AnimationParameter State_HitAdditiveBigC;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x146D0")]
		public static readonly AnimationParameter State_HitAdditiveC;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x14700")]
		public static readonly AnimationParameter State_HitAdditiveFrontA;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x14730")]
		public static readonly AnimationParameter State_HitAdditiveFrontB;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x14760")]
		public static readonly AnimationParameter State_HitAdditiveFrontC;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x14790")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterA;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x147C0")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterB;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x147F0")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterBigA;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x14820")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterBigB;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x14850")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterBigC;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x14880")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterC;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x148B0")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterRightRearLegA;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x148E0")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterRightRearLegB;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x14910")]
		public static readonly AnimationParameter State_HitAdditiveHelicopterRightRearLegC;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x14940")]
		public static readonly AnimationParameter State_HitAdditiveLeftA;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x14970")]
		public static readonly AnimationParameter State_HitAdditiveLeftArmA;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x149A0")]
		public static readonly AnimationParameter State_HitAdditiveLeftArmB;

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x149D0")]
		public static readonly AnimationParameter State_HitAdditiveLeftArmC;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x14A00")]
		public static readonly AnimationParameter State_HitAdditiveLeftB;

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x14A30")]
		public static readonly AnimationParameter State_HitAdditiveLeftC;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x14A60")]
		public static readonly AnimationParameter State_HitAdditiveLeftLegA;

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x14A90")]
		public static readonly AnimationParameter State_HitAdditiveLeftLegB;

		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		[FieldOffset(Offset = "0x14AC0")]
		public static readonly AnimationParameter State_HitAdditiveLeftLegC;

		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x14AF0")]
		public static readonly AnimationParameter State_HitAdditiveLeftLegRearA;

		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x14B20")]
		public static readonly AnimationParameter State_HitAdditiveLeftLegRearB;

		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x14B50")]
		public static readonly AnimationParameter State_HitAdditiveLeftLegRearC;

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x14B80")]
		public static readonly AnimationParameter State_HitAdditiveRightA;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x14BB0")]
		public static readonly AnimationParameter State_HitAdditiveRightArmA;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x14BE0")]
		public static readonly AnimationParameter State_HitAdditiveRightArmB;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x14C10")]
		public static readonly AnimationParameter State_HitAdditiveRightArmC;

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x14C40")]
		public static readonly AnimationParameter State_HitAdditiveRightB;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x14C70")]
		public static readonly AnimationParameter State_HitAdditiveRightC;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x14CA0")]
		public static readonly AnimationParameter State_HitAdditiveRightLegA;

		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x14CD0")]
		public static readonly AnimationParameter State_HitAdditiveRightLegB;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x14D00")]
		public static readonly AnimationParameter State_HitAdditiveRightLegC;

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x14D30")]
		public static readonly AnimationParameter State_HitAdditiveRightRearLegA;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x14D60")]
		public static readonly AnimationParameter State_HitAdditiveRightRearLegB;

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x14D90")]
		public static readonly AnimationParameter State_HitAdditiveRightRearLegC;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x14DC0")]
		public static readonly AnimationParameter State_HitArmLeftA;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x14DF0")]
		public static readonly AnimationParameter State_HitArmLeftB;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x14E20")]
		public static readonly AnimationParameter State_HitArmRightA;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x14E50")]
		public static readonly AnimationParameter State_HitArmRightB;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x14E80")]
		public static readonly AnimationParameter State_HitBehindTurnA;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x14EB0")]
		public static readonly AnimationParameter State_HitBehindTurnB;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x14EE0")]
		public static readonly AnimationParameter State_HitDefaultPassThrough;

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x14F10")]
		public static readonly AnimationParameter State_HitElectrocuted;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x14F40")]
		public static readonly AnimationParameter State_HitElectrocutedA;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x14F70")]
		public static readonly AnimationParameter State_HitElectrocutedAFall;

		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		[FieldOffset(Offset = "0x14FA0")]
		public static readonly AnimationParameter State_HitElectrocutedB;

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x14FD0")]
		public static readonly AnimationParameter State_HitElectrocutedBFall;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x15000")]
		public static readonly AnimationParameter State_HitElectrocutedIdle;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x15030")]
		public static readonly AnimationParameter State_HitElectrocutedIdleBack;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x15060")]
		public static readonly AnimationParameter State_HitElectrocutedIdleStomach;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x15090")]
		public static readonly AnimationParameter State_HitElectrocutedIntro;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x150C0")]
		public static readonly AnimationParameter State_HitElectrocutedOnBack;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x150F0")]
		public static readonly AnimationParameter State_HitElectrocutedOnStomach;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x15120")]
		public static readonly AnimationParameter State_HitElectrocutedOutro;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x15150")]
		public static readonly AnimationParameter State_HitExplosionBack;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x15180")]
		public static readonly AnimationParameter State_HitExplosionFront;

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x151B0")]
		public static readonly AnimationParameter State_HitExplosionHelicopterBack;

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x151E0")]
		public static readonly AnimationParameter State_HitExplosionHelicopterFront;

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x15210")]
		public static readonly AnimationParameter State_HitExplosionHelicopterLeft;

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x15240")]
		public static readonly AnimationParameter State_HitExplosionHelicopterRight;

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x15270")]
		public static readonly AnimationParameter State_HitExplosionLeft;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x152A0")]
		public static readonly AnimationParameter State_HitExplosionRight;

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x152D0")]
		public static readonly AnimationParameter State_HitFallBackDeath;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x15300")]
		public static readonly AnimationParameter State_HitFallBackwardA;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x15330")]
		public static readonly AnimationParameter State_HitFallForwardA;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x15360")]
		public static readonly AnimationParameter State_HitFallForwardDeath;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x15390")]
		public static readonly AnimationParameter State_HitFallLeft;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x153C0")]
		public static readonly AnimationParameter State_HitFallLeftDeath;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x153F0")]
		public static readonly AnimationParameter State_HitFallRight;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x15420")]
		public static readonly AnimationParameter State_HitFallRightDeath;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x15450")]
		public static readonly AnimationParameter State_HitFallStraightFromStanding;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x15480")]
		public static readonly AnimationParameter State_HitFallToLeftA;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		[FieldOffset(Offset = "0x154B0")]
		public static readonly AnimationParameter State_HitFallToRightA;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x154E0")]
		public static readonly AnimationParameter State_HitFromBack;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x15510")]
		public static readonly AnimationParameter State_HitFromExplosion;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x15540")]
		public static readonly AnimationParameter State_HitFront;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x15570")]
		public static readonly AnimationParameter State_HitFrontA;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x155A0")]
		public static readonly AnimationParameter State_HitFrontA2;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x155D0")]
		public static readonly AnimationParameter State_HitFrontA3;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x15600")]
		public static readonly AnimationParameter State_HitFrontB;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x15630")]
		public static readonly AnimationParameter State_hitHead;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x15660")]
		public static readonly AnimationParameter State_HitHead;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x15690")]
		public static readonly AnimationParameter State_HitHeadA;

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x156C0")]
		public static readonly AnimationParameter State_HitHeadB;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x156F0")]
		public static readonly AnimationParameter State_HitHeadBehind;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x15720")]
		public static readonly AnimationParameter State_HitHeadBig;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x15750")]
		public static readonly AnimationParameter State_HitHeadC;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x15780")]
		public static readonly AnimationParameter State_HitHeadLeft;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x157B0")]
		public static readonly AnimationParameter State_HitHeadRight;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x157E0")]
		public static readonly AnimationParameter State_HitHeadSmall;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x15810")]
		public static readonly AnimationParameter State_HitInjured;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x15840")]
		public static readonly AnimationParameter State_HitInjuredSit;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x15870")]
		public static readonly AnimationParameter State_hitKnockBack;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x158A0")]
		public static readonly AnimationParameter State_hitKnockBackChainsaw;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x158D0")]
		public static readonly AnimationParameter State_hitKnockBackCraftedBow;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x15900")]
		public static readonly AnimationParameter State_hitKnockBackMachete;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x15930")]
		public static readonly AnimationParameter State_hitKnockBackSeveredArm;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x15960")]
		public static readonly AnimationParameter State_hitKnockBackSeveredLeg;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x15990")]
		public static readonly AnimationParameter State_hitKnockBackShotgun;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x159C0")]
		public static readonly AnimationParameter State_HitKnockoutBehind;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x159F0")]
		public static readonly AnimationParameter State_HitKnockoutLeft;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x15A20")]
		public static readonly AnimationParameter State_HitKnockoutLeftA;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0x15A50")]
		public static readonly AnimationParameter State_HitKnockoutRight;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x15A80")]
		public static readonly AnimationParameter State_HitKnockoutRightA;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x15AB0")]
		public static readonly AnimationParameter State_hitLeft;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x15AE0")]
		public static readonly AnimationParameter State_HitLeftA;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x15B10")]
		public static readonly AnimationParameter State_hitLeftBig;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x15B40")]
		public static readonly AnimationParameter State_hitLeftLeg;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x15B70")]
		public static readonly AnimationParameter State_HitLegLeft;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x15BA0")]
		public static readonly AnimationParameter State_HitLegRight;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x15BD0")]
		public static readonly AnimationParameter State_HitMolotov;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x15C00")]
		public static readonly AnimationParameter State_HitMolotovA;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x15C30")]
		public static readonly AnimationParameter State_HitMolotovB;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x15C60")]
		public static readonly AnimationParameter State_HitResponse;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x15C90")]
		public static readonly AnimationParameter State_HitResponseBehindFrontSmall;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x15CC0")]
		public static readonly AnimationParameter State_HitResponseBehindLeftSmall;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x15CF0")]
		public static readonly AnimationParameter State_HitResponseBehindRightSmall;

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x15D20")]
		public static readonly AnimationParameter State_HitResponseFallToTheGround;

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x15D50")]
		public static readonly AnimationParameter State_HitResponseFront;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x15D80")]
		public static readonly AnimationParameter State_HitResponseFrontSmall;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x15DB0")]
		public static readonly AnimationParameter State_HitResponseLeftBody;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x15DE0")]
		public static readonly AnimationParameter State_HitResponseLeftFrontLegs;

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x15E10")]
		public static readonly AnimationParameter State_HitResponseLeftSmall;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x15E40")]
		public static readonly AnimationParameter State_HitResponseRightBody;

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x15E70")]
		public static readonly AnimationParameter State_HitResponseRightFrontLegs;

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x15EA0")]
		public static readonly AnimationParameter State_HitResponseRightSmall;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x15ED0")]
		public static readonly AnimationParameter State_HitResponseStumbleBack;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x15F00")]
		public static readonly AnimationParameter State_hitRight;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x15F30")]
		public static readonly AnimationParameter State_HitRightA;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x15F60")]
		public static readonly AnimationParameter State_hitRightBig;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x15F90")]
		public static readonly AnimationParameter State_hitRightLeg;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x15FC0")]
		public static readonly AnimationParameter State_HitsDefaultPassthrough;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x15FF0")]
		public static readonly AnimationParameter State_HitShotgunBack;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x16020")]
		public static readonly AnimationParameter State_HitShotgunDeath;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x16050")]
		public static readonly AnimationParameter State_HitShotgunFront;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x16080")]
		public static readonly AnimationParameter State_HitShotgunLeft;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x160B0")]
		public static readonly AnimationParameter State_HitShotgunRight;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x160E0")]
		public static readonly AnimationParameter State_HitShotugun;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x16110")]
		public static readonly AnimationParameter State_HitShotugunDeath;

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0x16140")]
		public static readonly AnimationParameter State_HitSmallBehind;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x16170")]
		public static readonly AnimationParameter State_HitSmallFront;

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x161A0")]
		public static readonly AnimationParameter State_HitSmallLeft;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x161D0")]
		public static readonly AnimationParameter State_HitSmallRight;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x16200")]
		public static readonly AnimationParameter State_HitStaggerBackA;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x16230")]
		public static readonly AnimationParameter State_HitStaggerBackB;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x16260")]
		public static readonly AnimationParameter State_HitStaggerBehindA;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x16290")]
		public static readonly AnimationParameter State_HitStaggerBehindB;

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x162C0")]
		public static readonly AnimationParameter State_HitStaggerFrontA;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x162F0")]
		public static readonly AnimationParameter State_HitStaggerFrontB;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x16320")]
		public static readonly AnimationParameter State_HitStaggerFrontC;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x16350")]
		public static readonly AnimationParameter State_HitStaggerFrontD;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x16380")]
		public static readonly AnimationParameter State_HitStaggerLeftA;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x163B0")]
		public static readonly AnimationParameter State_HitStaggerLeftArm;

		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4000881")]
		[FieldOffset(Offset = "0x163E0")]
		public static readonly AnimationParameter State_HitStaggerLeftB;

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		[FieldOffset(Offset = "0x16410")]
		public static readonly AnimationParameter State_HitStaggerLeftLeg;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0x16440")]
		public static readonly AnimationParameter State_HitStaggerRightA;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x16470")]
		public static readonly AnimationParameter State_HitStaggerRightArm;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x164A0")]
		public static readonly AnimationParameter State_HitStaggerRightB;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x164D0")]
		public static readonly AnimationParameter State_HitStaggerRightLeg;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0x16500")]
		public static readonly AnimationParameter State_HitStaggerSpinLeftA;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0x16530")]
		public static readonly AnimationParameter State_HitStaggerSpinLeftB;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x16560")]
		public static readonly AnimationParameter State_HitStaggerSpinRightA;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x16590")]
		public static readonly AnimationParameter State_hitStomach;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x165C0")]
		public static readonly AnimationParameter State_HitStomach;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x165F0")]
		public static readonly AnimationParameter State_HitStomachSlowDeath;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x16620")]
		public static readonly AnimationParameter State_hitStumbleBack;

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0x16650")]
		public static readonly AnimationParameter State_HitTranquilizerA;

		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0x16680")]
		public static readonly AnimationParameter State_HitTranquilizerB;

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x166B0")]
		public static readonly AnimationParameter State_HitUpperbodyA;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0x166E0")]
		public static readonly AnimationParameter State_HitUpperbodyB;

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x16710")]
		public static readonly AnimationParameter State_HitUpperbodyC;

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x16740")]
		public static readonly AnimationParameter State_holdMap;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x16770")]
		public static readonly AnimationParameter State_holdPouchLoop;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x167A0")]
		public static readonly AnimationParameter State_holdWideIdle;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x167D0")]
		public static readonly AnimationParameter State_HorsetailCraftHerbMix;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x16800")]
		public static readonly AnimationParameter State_HorsetailIdle;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x16830")]
		public static readonly AnimationParameter State_Hover_to_Normal;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x16860")]
		public static readonly AnimationParameter State_Hover_to_Pressed;

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x16890")]
		public static readonly AnimationParameter State_HoverDartA;

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0x168C0")]
		public static readonly AnimationParameter State_HoverDartB;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0x168F0")]
		public static readonly AnimationParameter State_HoverEat;

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x16920")]
		public static readonly AnimationParameter State_HugPlayer;

		// Token: 0x0400089E RID: 2206
		[Token(Token = "0x400089E")]
		[FieldOffset(Offset = "0x16950")]
		public static readonly AnimationParameter State_idle;

		// Token: 0x0400089F RID: 2207
		[Token(Token = "0x400089F")]
		[FieldOffset(Offset = "0x16980")]
		public static readonly AnimationParameter State_Idle;

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x40008A0")]
		[FieldOffset(Offset = "0x169B0")]
		public static readonly AnimationParameter State_idle_look_left;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0x169E0")]
		public static readonly AnimationParameter State_idle_look_right;

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x16A10")]
		public static readonly AnimationParameter State_idle_trot;

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x16A40")]
		public static readonly AnimationParameter State_idle_trot180;

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x16A70")]
		public static readonly AnimationParameter State_idle_trotLeft;

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x16AA0")]
		public static readonly AnimationParameter State_idle_trotRight;

		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		[FieldOffset(Offset = "0x16AD0")]
		public static readonly AnimationParameter State_idle_walk;

		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		[FieldOffset(Offset = "0x16B00")]
		public static readonly AnimationParameter State_idle_walk180;

		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		[FieldOffset(Offset = "0x16B30")]
		public static readonly AnimationParameter State_idle_walkLeft;

		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		[FieldOffset(Offset = "0x16B60")]
		public static readonly AnimationParameter State_idle_walkRight;

		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		[FieldOffset(Offset = "0x16B90")]
		public static readonly AnimationParameter State_IdleA;

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		[FieldOffset(Offset = "0x16BC0")]
		public static readonly AnimationParameter State_idleAggressive;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0x16BF0")]
		public static readonly AnimationParameter State_IdleAgitated;

		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		[FieldOffset(Offset = "0x16C20")]
		public static readonly AnimationParameter State_idleAttackToIdle;

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x16C50")]
		public static readonly AnimationParameter State_IdleB;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x16C80")]
		public static readonly AnimationParameter State_idleBase;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x16CB0")]
		public static readonly AnimationParameter State_idleCalm;

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x16CE0")]
		public static readonly AnimationParameter State_IdleClosed;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x16D10")]
		public static readonly AnimationParameter State_IdleClub;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x16D40")]
		public static readonly AnimationParameter State_idleClub;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x16D70")]
		public static readonly AnimationParameter State_IdleCrouch;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x16DA0")]
		public static readonly AnimationParameter State_IdleCrouchA;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x16DD0")]
		public static readonly AnimationParameter State_IdleCrouchB;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0x16E00")]
		public static readonly AnimationParameter State_IdleCrouchToIdle;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x16E30")]
		public static readonly AnimationParameter State_IdleCrouchToIdleAlerted;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x16E60")]
		public static readonly AnimationParameter State_IdleCrouchToToIdle;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x16E90")]
		public static readonly AnimationParameter State_idleDodge;

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x16EC0")]
		public static readonly AnimationParameter State_idleDrinkFromFlask;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x16EF0")]
		public static readonly AnimationParameter State_idleEmpty;

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x16F20")]
		public static readonly AnimationParameter State_IdleFidgetA;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x16F50")]
		public static readonly AnimationParameter State_IdleFinished;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x16F80")]
		public static readonly AnimationParameter State_IdleGolfPutter;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x16FB0")]
		public static readonly AnimationParameter State_IdleHeadDown;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x16FE0")]
		public static readonly AnimationParameter State_IdleHiddenA;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x17010")]
		public static readonly AnimationParameter State_IdleKatana;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0x17040")]
		public static readonly AnimationParameter State_IdleKnife;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x17070")]
		public static readonly AnimationParameter State_IdleLook;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x170A0")]
		public static readonly AnimationParameter State_IdleLookAroundIntro;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x170D0")]
		public static readonly AnimationParameter State_IdleLookAroundOutro;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0x17100")]
		public static readonly AnimationParameter State_IdleLookVar1;

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		[FieldOffset(Offset = "0x17130")]
		public static readonly AnimationParameter State_idleLoop;

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		[FieldOffset(Offset = "0x17160")]
		public static readonly AnimationParameter State_idleLoopB;

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x17190")]
		public static readonly AnimationParameter State_idleLoopC;

		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		[FieldOffset(Offset = "0x171C0")]
		public static readonly AnimationParameter State_idleLoopD;

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		[FieldOffset(Offset = "0x171F0")]
		public static readonly AnimationParameter State_idleLoopE;

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0x17220")]
		public static readonly AnimationParameter State_IdleMachete;

		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		[FieldOffset(Offset = "0x17250")]
		public static readonly AnimationParameter State_idleMP;

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0x17280")]
		public static readonly AnimationParameter State_idleNoWobble;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x172B0")]
		public static readonly AnimationParameter State_idlePlayerAStickLift;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x172E0")]
		public static readonly AnimationParameter State_IdleRepairTool;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x17310")]
		public static readonly AnimationParameter State_IdleScratchHead;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x17340")]
		public static readonly AnimationParameter State_IdleSmallerBodyOnTop1;

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0x17370")]
		public static readonly AnimationParameter State_IdleSmallerBodyOnTop1ToIdle;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x173A0")]
		public static readonly AnimationParameter State_IdleSmallerBodyOnTop2;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x173D0")]
		public static readonly AnimationParameter State_IdleSmallerBodyOnTop2ToIdle;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x17400")]
		public static readonly AnimationParameter State_IdleSmallerBodyOnTopToAttackComboForward1SmallerBodyOnTop;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		[FieldOffset(Offset = "0x17430")]
		public static readonly AnimationParameter State_IdleSmallerBodyOnTopToWalkForwardSmallerBodyOnTop;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		[FieldOffset(Offset = "0x17460")]
		public static readonly AnimationParameter State_idleStick;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		[FieldOffset(Offset = "0x17490")]
		public static readonly AnimationParameter State_IdleSwatFly;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		[FieldOffset(Offset = "0x174C0")]
		public static readonly AnimationParameter State_IdleSwim;

		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		[FieldOffset(Offset = "0x174F0")]
		public static readonly AnimationParameter State_IdleSwimToSwimForward;

		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		[FieldOffset(Offset = "0x17520")]
		public static readonly AnimationParameter State_IdleTacticalAxe;

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		[FieldOffset(Offset = "0x17550")]
		public static readonly AnimationParameter State_IdleTaserStick;

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		[FieldOffset(Offset = "0x17580")]
		public static readonly AnimationParameter State_idleTaunt1;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0x175B0")]
		public static readonly AnimationParameter State_idleToAim;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0x175E0")]
		public static readonly AnimationParameter State_idleToAim_0;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0x17610")]
		public static readonly AnimationParameter State_IdleToAlertedLeft;

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		[FieldOffset(Offset = "0x17640")]
		public static readonly AnimationParameter State_IdleToAlertedRight;

		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		[FieldOffset(Offset = "0x17670")]
		public static readonly AnimationParameter State_IdleToBackAway;

		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		[FieldOffset(Offset = "0x176A0")]
		public static readonly AnimationParameter State_idleToBallIdle;

		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		[FieldOffset(Offset = "0x176D0")]
		public static readonly AnimationParameter State_idleToBallIdle_0;

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0x17700")]
		public static readonly AnimationParameter State_IdleToBonePlantAndTwist;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x17730")]
		public static readonly AnimationParameter State_idleToBookIdle;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		[FieldOffset(Offset = "0x17760")]
		public static readonly AnimationParameter State_idleToBowIdle;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0x17790")]
		public static readonly AnimationParameter State_idleToBowIdle_0;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0x177C0")]
		public static readonly AnimationParameter State_idleToCampSitting;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		[FieldOffset(Offset = "0x177F0")]
		public static readonly AnimationParameter State_idleToCarryBody;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		[FieldOffset(Offset = "0x17820")]
		public static readonly AnimationParameter State_IdleToCarryLog;

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		[FieldOffset(Offset = "0x17850")]
		public static readonly AnimationParameter State_idleToCarryLog;

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		[FieldOffset(Offset = "0x17880")]
		public static readonly AnimationParameter State_idleToCarryLog_0;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0x178B0")]
		public static readonly AnimationParameter State_IdleToCatchFish;

		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		[FieldOffset(Offset = "0x178E0")]
		public static readonly AnimationParameter State_IdleToCircleLeft;

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		[FieldOffset(Offset = "0x17910")]
		public static readonly AnimationParameter State_IdleToCircleLeftFast;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0x17940")]
		public static readonly AnimationParameter State_IdleToCircleRight;

		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		[FieldOffset(Offset = "0x17970")]
		public static readonly AnimationParameter State_IdleToCircleRightFast;

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0x179A0")]
		public static readonly AnimationParameter State_idleToClimbIdle;

		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0x179D0")]
		public static readonly AnimationParameter State_idleToClimbRopeTop;

		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		[FieldOffset(Offset = "0x17A00")]
		public static readonly AnimationParameter State_idleToClubBlock;

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0x17A30")]
		public static readonly AnimationParameter State_IdleToCower;

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0x17A60")]
		public static readonly AnimationParameter State_IdleToCrawl;

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0x17A90")]
		public static readonly AnimationParameter State_IdleToCutPilarHit;

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x17AC0")]
		public static readonly AnimationParameter State_IdleToDanceCasual;

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		[FieldOffset(Offset = "0x17AF0")]
		public static readonly AnimationParameter State_IdleToDeathOnBack;

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x17B20")]
		public static readonly AnimationParameter State_IdleToDragAway;

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0x17B50")]
		public static readonly AnimationParameter State_IdleToDrink;

		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		[FieldOffset(Offset = "0x17B80")]
		public static readonly AnimationParameter State_IdleToDropFromCeiling;

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0x17BB0")]
		public static readonly AnimationParameter State_IdleToEat;

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x17BE0")]
		public static readonly AnimationParameter State_IdleToEatDeadBody;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x17C10")]
		public static readonly AnimationParameter State_IdleToEating;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x17C40")]
		public static readonly AnimationParameter State_IdleToEatMeatGround;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		[FieldOffset(Offset = "0x17C70")]
		public static readonly AnimationParameter State_idleToFlare;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[FieldOffset(Offset = "0x17CA0")]
		public static readonly AnimationParameter State_idleToFlare_0;

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0x17CD0")]
		public static readonly AnimationParameter State_idleToFlickLock;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x17D00")]
		public static readonly AnimationParameter State_IdleToGallop;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x17D30")]
		public static readonly AnimationParameter State_IdleToGallop180;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x17D60")]
		public static readonly AnimationParameter State_IdleToGallopLeft;

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		[FieldOffset(Offset = "0x17D90")]
		public static readonly AnimationParameter State_IdleToGallopRight;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x17DC0")]
		public static readonly AnimationParameter State_idleToGirlPickup;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x17DF0")]
		public static readonly AnimationParameter State_idleToGirlPickup_0;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x17E20")]
		public static readonly AnimationParameter State_IdleToHeadDown;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x17E50")]
		public static readonly AnimationParameter State_idleToHeavyAxeBlock;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x17E80")]
		public static readonly AnimationParameter State_IdleToHeavyBreathing;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x17EB0")]
		public static readonly AnimationParameter State_IdleToHide;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x17EE0")]
		public static readonly AnimationParameter State_IdleToHideInShell;

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x17F10")]
		public static readonly AnimationParameter State_IdleToHideInShellFast;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x17F40")]
		public static readonly AnimationParameter State_idleToHold;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x17F70")]
		public static readonly AnimationParameter State_idleToHold_0;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x17FA0")]
		public static readonly AnimationParameter State_idleToHoldPouch;

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x17FD0")]
		public static readonly AnimationParameter State_idleToHoldPouch_0;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x18000")]
		public static readonly AnimationParameter State_idleToHoldPouch_0_0;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x18030")]
		public static readonly AnimationParameter State_idleToHoldPouch_1;

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x18060")]
		public static readonly AnimationParameter State_idleToHoldWide;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x18090")]
		public static readonly AnimationParameter State_idleToHoldWide_0;

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x180C0")]
		public static readonly AnimationParameter State_IdleToIdleCrouch;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x180F0")]
		public static readonly AnimationParameter State_IdleToIdleSmallerBodyOnTop1;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x18120")]
		public static readonly AnimationParameter State_IdleToIdleSmallerBodyOnTop2;

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x18150")]
		public static readonly AnimationParameter State_IdleToIdleToCrouch;

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x18180")]
		public static readonly AnimationParameter State_IdleToInjured;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x181B0")]
		public static readonly AnimationParameter State_IdleToJog180;

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x181E0")]
		public static readonly AnimationParameter State_IdleToJogAggressive;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x18210")]
		public static readonly AnimationParameter State_IdleToJogLeft;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x18240")]
		public static readonly AnimationParameter State_IdleToJogRight;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x18270")]
		public static readonly AnimationParameter State_idleToJump;

		// Token: 0x04000925 RID: 2341
		[Token(Token = "0x4000925")]
		[FieldOffset(Offset = "0x182A0")]
		public static readonly AnimationParameter State_idleToJumpArmed;

		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		[FieldOffset(Offset = "0x182D0")]
		public static readonly AnimationParameter State_idleToKatanaBlock;

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x18300")]
		public static readonly AnimationParameter State_IdleToLay;

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0x18330")]
		public static readonly AnimationParameter State_idleToLighterIdle;

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x18360")]
		public static readonly AnimationParameter State_IdleToLighterIdle;

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		[FieldOffset(Offset = "0x18390")]
		public static readonly AnimationParameter State_idleToLighterIdleGlider;

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		[FieldOffset(Offset = "0x183C0")]
		public static readonly AnimationParameter State_idleToLookAtCD;

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x183F0")]
		public static readonly AnimationParameter State_idleToLookAtPhoto;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x18420")]
		public static readonly AnimationParameter State_idleToLookAtPhoto_0;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x18450")]
		public static readonly AnimationParameter State_idleToLookItem;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x18480")]
		public static readonly AnimationParameter State_idleToLookItemRight;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		[FieldOffset(Offset = "0x184B0")]
		public static readonly AnimationParameter State_idleToMacheteBlock;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		[FieldOffset(Offset = "0x184E0")]
		public static readonly AnimationParameter State_idleToMolotovIdle;

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[FieldOffset(Offset = "0x18510")]
		public static readonly AnimationParameter State_idleToMolotovIdle_0;

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x18540")]
		public static readonly AnimationParameter State_IdleToOnLadder;

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x18570")]
		public static readonly AnimationParameter State_idleToPedIdle;

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x185A0")]
		public static readonly AnimationParameter State_idleToPedIdle_0;

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x185D0")]
		public static readonly AnimationParameter State_idleToPhotoIdle;

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x18600")]
		public static readonly AnimationParameter State_idleToPlayerAStickLift;

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x18630")]
		public static readonly AnimationParameter State_idleToPlayerAStickPlaceHorizontal;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x18660")]
		public static readonly AnimationParameter State_IdleToPrayA;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0x18690")]
		public static readonly AnimationParameter State_IdleToPrayB;

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x186C0")]
		public static readonly AnimationParameter State_IdleToPushBone;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x186F0")]
		public static readonly AnimationParameter State_idleToPushSled;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x18720")]
		public static readonly AnimationParameter State_idleToRepairHammerAttack;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x18750")]
		public static readonly AnimationParameter State_IdleToRest;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x18780")]
		public static readonly AnimationParameter State_idleToRockIdle;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x187B0")]
		public static readonly AnimationParameter State_idleToRockIdle_0;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x187E0")]
		public static readonly AnimationParameter State_idleToRockslowAttack;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x18810")]
		public static readonly AnimationParameter State_idleToRopClimb_0;

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x18840")]
		public static readonly AnimationParameter State_idleToRopeClimb;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x18870")]
		public static readonly AnimationParameter State_IdleToRun;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x188A0")]
		public static readonly AnimationParameter State_IdleToRun180;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x188D0")]
		public static readonly AnimationParameter State_IdleToRunAggressive;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x18900")]
		public static readonly AnimationParameter State_idleToRunFast2;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x18930")]
		public static readonly AnimationParameter State_IdleToRunForward;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x18960")]
		public static readonly AnimationParameter State_IdleToRunForward180;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0x18990")]
		public static readonly AnimationParameter State_IdleToRunForwardAggressive;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0x189C0")]
		public static readonly AnimationParameter State_IdleToRunLeft;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x189F0")]
		public static readonly AnimationParameter State_IdleToRunRight;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x18A20")]
		public static readonly AnimationParameter State_idleToSapIdle;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x18A50")]
		public static readonly AnimationParameter State_idleToShellBlock;

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0x18A80")]
		public static readonly AnimationParameter State_idleToShellBlock_0;

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		[FieldOffset(Offset = "0x18AB0")]
		public static readonly AnimationParameter State_idleToShellHeld;

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x18AE0")]
		public static readonly AnimationParameter State_IdleToSitA;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x18B10")]
		public static readonly AnimationParameter State_IdleToSitB;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x18B40")]
		public static readonly AnimationParameter State_IdleToSitC;

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x18B70")]
		public static readonly AnimationParameter State_IdleToSitChair;

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x18BA0")]
		public static readonly AnimationParameter State_IdleToSitD;

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x18BD0")]
		public static readonly AnimationParameter State_idleToSitDown;

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x18C00")]
		public static readonly AnimationParameter State_IdleToSitRubToes;

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x18C30")]
		public static readonly AnimationParameter State_IdleToSleep;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x18C60")]
		public static readonly AnimationParameter State_IdleToSleepB;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x18C90")]
		public static readonly AnimationParameter State_idleToSlowAxeAttack;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x18CC0")]
		public static readonly AnimationParameter State_idleToSpearIdle;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0x18CF0")]
		public static readonly AnimationParameter State_idleToSpearIdle_0;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x18D20")]
		public static readonly AnimationParameter State_idleToSpearThrowIdle;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0x18D50")]
		public static readonly AnimationParameter State_idleToSpearThrowIdle_0;

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x18D80")]
		public static readonly AnimationParameter State_IdleToSprintForward;

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x18DB0")]
		public static readonly AnimationParameter State_IdleToStepBack;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x18DE0")]
		public static readonly AnimationParameter State_IdletoStepCurious;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x18E10")]
		public static readonly AnimationParameter State_IdleToStepCuriousBack;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x18E40")]
		public static readonly AnimationParameter State_idleToStickBlock;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x18E70")]
		public static readonly AnimationParameter State_idleToStickBreakAndPlace;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x18EA0")]
		public static readonly AnimationParameter State_idleToStickJabIdle;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x18ED0")]
		public static readonly AnimationParameter State_idleToStickJabIdle_0;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0x18F00")]
		public static readonly AnimationParameter State_idleToStickPlantAndTwist;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x18F30")]
		public static readonly AnimationParameter State_IdleToStrafe;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x18F60")]
		public static readonly AnimationParameter State_idleToTacticalAxeBlock;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x18F90")]
		public static readonly AnimationParameter State_idleToTacticalBowIdle;

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0x18FC0")]
		public static readonly AnimationParameter State_idleToTaserStickBlock;

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x18FF0")]
		public static readonly AnimationParameter State_IdleToTaserStickBlock;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x19020")]
		public static readonly AnimationParameter State_IdleToTaserStickJabIdle;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x19050")]
		public static readonly AnimationParameter State_idleToThrowerIdle;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x19080")]
		public static readonly AnimationParameter State_idleToTreeChopIdle;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x190B0")]
		public static readonly AnimationParameter State_IdleToTreeCut;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x190E0")]
		public static readonly AnimationParameter State_IdleToTrot;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x19110")]
		public static readonly AnimationParameter State_idleToWalk;

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x19140")]
		public static readonly AnimationParameter State_IdleToWalk;

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x19170")]
		public static readonly AnimationParameter State_IdleToWalk180;

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x191A0")]
		public static readonly AnimationParameter State_IdleToWalk180Slow;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x191D0")]
		public static readonly AnimationParameter State_IdleToWalkAggressive;

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x19200")]
		public static readonly AnimationParameter State_IdleToWalkAggressive180;

		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		[FieldOffset(Offset = "0x19230")]
		public static readonly AnimationParameter State_IdleToWalkAggressive180Female;

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x19260")]
		public static readonly AnimationParameter State_IdleToWalkAggressiveFemale;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x19290")]
		public static readonly AnimationParameter State_IdleToWalkAggressiveLeft;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x192C0")]
		public static readonly AnimationParameter State_IdleToWalkAggressiveLeftFemale;

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x192F0")]
		public static readonly AnimationParameter State_IdleToWalkAggressiveRight;

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x19320")]
		public static readonly AnimationParameter State_IdleToWalkAggressiveRightFemale;

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		[FieldOffset(Offset = "0x19350")]
		public static readonly AnimationParameter State_idleToWalkBack;

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x19380")]
		public static readonly AnimationParameter State_IdleToWalkBack;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x193B0")]
		public static readonly AnimationParameter State_IdleToWalkBackward;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x193E0")]
		public static readonly AnimationParameter State_IdleToWalkBackwardFast;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x19410")]
		public static readonly AnimationParameter State_IdleToWalkFast180;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x19440")]
		public static readonly AnimationParameter State_IdleToWalkFastLeft;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[FieldOffset(Offset = "0x19470")]
		public static readonly AnimationParameter State_IdleToWalkFastRight;

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		[FieldOffset(Offset = "0x194A0")]
		public static readonly AnimationParameter State_IdleToWalkForwardAggressive;

		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		[FieldOffset(Offset = "0x194D0")]
		public static readonly AnimationParameter State_IdleToWalkForwardFast;

		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		[FieldOffset(Offset = "0x19500")]
		public static readonly AnimationParameter State_IdleToWalkForwardSlow;

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x19530")]
		public static readonly AnimationParameter State_IdleToWalkLeft;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x19560")]
		public static readonly AnimationParameter State_IdleToWalkLeftSlow;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x19590")]
		public static readonly AnimationParameter State_idleToWalkmanIdle;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x195C0")]
		public static readonly AnimationParameter State_idleToWalkmanIdle_0;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x195F0")]
		public static readonly AnimationParameter State_IdleToWalkPassive;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x19620")]
		public static readonly AnimationParameter State_IdleToWalkRight;

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x19650")]
		public static readonly AnimationParameter State_IdleToWalkRightSlow;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x19680")]
		public static readonly AnimationParameter State_IdleToWalkSlow180;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x196B0")]
		public static readonly AnimationParameter State_IdleToWalkSlowLeft;

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x196E0")]
		public static readonly AnimationParameter State_IdleToWalkSlowRight;

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x19710")]
		public static readonly AnimationParameter State_idleToZip;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x19740")]
		public static readonly AnimationParameter State_idleVar1;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x19770")]
		public static readonly AnimationParameter State_idleVar2;

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x197A0")]
		public static readonly AnimationParameter State_IdleVillageA;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x197D0")]
		public static readonly AnimationParameter State_IdleVillageB;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x19800")]
		public static readonly AnimationParameter State_IdleVillageC;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x19830")]
		public static readonly AnimationParameter State_IdleWaterA;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x19860")]
		public static readonly AnimationParameter State_IdleWaterB;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x19890")]
		public static readonly AnimationParameter State_In;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x198C0")]
		public static readonly AnimationParameter State_In_Loop;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x198F0")]
		public static readonly AnimationParameter State_Inactive;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x19920")]
		public static readonly AnimationParameter State_Injured;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x19950")]
		public static readonly AnimationParameter State_InjuredDeath;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x19980")]
		public static readonly AnimationParameter State_InjuredDeathLeft;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x199B0")]
		public static readonly AnimationParameter State_InjuredDeathRight;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x199E0")]
		public static readonly AnimationParameter State_injuredFall;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x19A10")]
		public static readonly AnimationParameter State_injuredFallC;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x19A40")]
		public static readonly AnimationParameter State_injuredLoop;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x19A70")]
		public static readonly AnimationParameter State_InjuredLoop;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x19AA0")]
		public static readonly AnimationParameter State_InjuredOnBackDying;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x19AD0")]
		public static readonly AnimationParameter State_InjuredOnBackStandup;

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		[FieldOffset(Offset = "0x19B00")]
		public static readonly AnimationParameter State_InjuredOnBackStandup_1;

		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		[FieldOffset(Offset = "0x19B30")]
		public static readonly AnimationParameter State_InjuredOnStomach;

		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0x19B60")]
		public static readonly AnimationParameter State_InjuredOnStomachStandup;

		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		[FieldOffset(Offset = "0x19B90")]
		public static readonly AnimationParameter State_InjuredSitDeath;

		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		[FieldOffset(Offset = "0x19BC0")]
		public static readonly AnimationParameter State_InjuredToIdle;

		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		[FieldOffset(Offset = "0x19BF0")]
		public static readonly AnimationParameter State_Intro;

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x19C20")]
		public static readonly AnimationParameter State_introFlyingLoop;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x19C50")]
		public static readonly AnimationParameter State_IntroToWounded;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x19C80")]
		public static readonly AnimationParameter State_IntroTreeCrashStandUpHelicopter;

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0x19CB0")]
		public static readonly AnimationParameter State_InventoryIdle;

		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0x19CE0")]
		public static readonly AnimationParameter State_inventoryIdle;

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		[FieldOffset(Offset = "0x19D10")]
		public static readonly AnimationParameter State_InventoryInteract;

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0x19D40")]
		public static readonly AnimationParameter State_InventoryKneelIdle;

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x19D70")]
		public static readonly AnimationParameter State_InventoryKneelIntro;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x19DA0")]
		public static readonly AnimationParameter State_InventoryKneelOutro;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x19DD0")]
		public static readonly AnimationParameter State_InventoryLayoutGroupsRollout;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x19E00")]
		public static readonly AnimationParameter State_InvestigateBushA;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x19E30")]
		public static readonly AnimationParameter State_InvestigateBushB;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x19E60")]
		public static readonly AnimationParameter State_JawOpenAngry;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x19E90")]
		public static readonly AnimationParameter State_JawOpenScared;

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x19EC0")]
		public static readonly AnimationParameter State_JawOpenYell;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x19EF0")]
		public static readonly AnimationParameter State_JogAggressive;

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		[FieldOffset(Offset = "0x19F20")]
		public static readonly AnimationParameter State_JogAggressiveToIdle;

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		[FieldOffset(Offset = "0x19F50")]
		public static readonly AnimationParameter State_JogToTurn180;

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		[FieldOffset(Offset = "0x19F80")]
		public static readonly AnimationParameter State_JogToTurnLeft;

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x19FB0")]
		public static readonly AnimationParameter State_JogToTurnRight;

		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x19FE0")]
		public static readonly AnimationParameter State_jumpAirLoop;

		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x1A010")]
		public static readonly AnimationParameter State_JumpAttack;

		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x1A040")]
		public static readonly AnimationParameter State_JumpAttackFromTree;

		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0x1A070")]
		public static readonly AnimationParameter State_JumpAttackFromTreeLeft;

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0x1A0A0")]
		public static readonly AnimationParameter State_JumpAttackFromTreeRight;

		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0x1A0D0")]
		public static readonly AnimationParameter State_jumpComplete;

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x1A100")]
		public static readonly AnimationParameter State_JumpOffEdge;

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x1A130")]
		public static readonly AnimationParameter State_JumpOffFall;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x1A160")]
		public static readonly AnimationParameter State_JumpOffLand;

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x1A190")]
		public static readonly AnimationParameter State_JumpOffLand2;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x1A1C0")]
		public static readonly AnimationParameter State_JumpOffOverWall;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x1A1F0")]
		public static readonly AnimationParameter State_JumpOffRockAttack;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x1A220")]
		public static readonly AnimationParameter State_JumpOffRockBack;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x1A250")]
		public static readonly AnimationParameter State_JumpOffRockFront;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x1A280")]
		public static readonly AnimationParameter State_JumpOffTree;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x1A2B0")]
		public static readonly AnimationParameter State_JumpOffZipline;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x1A2E0")]
		public static readonly AnimationParameter State_JumpOnRock;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x1A310")]
		public static readonly AnimationParameter State_JumpOnToWall;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x1A340")]
		public static readonly AnimationParameter State_JumpOntoZipline;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x1A370")]
		public static readonly AnimationParameter State_JumpOnTree;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x1A3A0")]
		public static readonly AnimationParameter State_JumpOutOfWaterAttack;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x1A3D0")]
		public static readonly AnimationParameter State_JumpOverBig;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x1A400")]
		public static readonly AnimationParameter State_JumpOverSmall;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x1A430")]
		public static readonly AnimationParameter State_JumpOverSmallJog;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x1A460")]
		public static readonly AnimationParameter State_JumpOverSmallWalk;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x1A490")]
		public static readonly AnimationParameter State_JumpToCeiling;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x1A4C0")]
		public static readonly AnimationParameter State_JumpUpBig;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x1A4F0")]
		public static readonly AnimationParameter State_JumpUpMedium;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x1A520")]
		public static readonly AnimationParameter State_JumpUpSmall;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x1A550")]
		public static readonly AnimationParameter State_KatanaAttackToLeftA;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x1A580")]
		public static readonly AnimationParameter State_KatanaAttackToRightA;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x1A5B0")]
		public static readonly AnimationParameter State_KatanaAttackToRightHeavyAttackWindup;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x1A5E0")]
		public static readonly AnimationParameter State_KatanaBlock1;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x1A610")]
		public static readonly AnimationParameter State_KatanaBlock2;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x1A640")]
		public static readonly AnimationParameter State_KatanaBlockedLeftA;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x1A670")]
		public static readonly AnimationParameter State_KatanaBlockedRightA;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x1A6A0")]
		public static readonly AnimationParameter State_KatanaBlockHit1;

		// Token: 0x040009E6 RID: 2534
		[Token(Token = "0x40009E6")]
		[FieldOffset(Offset = "0x1A6D0")]
		public static readonly AnimationParameter State_KatanaBlockHit2;

		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0x1A700")]
		public static readonly AnimationParameter State_KatanaBlockToIdle;

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x1A730")]
		public static readonly AnimationParameter State_KatanaEquip;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x1A760")]
		public static readonly AnimationParameter State_KatanaFirstTime;

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0x1A790")]
		public static readonly AnimationParameter State_KatanaGround;

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x1A7C0")]
		public static readonly AnimationParameter State_KatanaHeavyAttack;

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0x1A7F0")]
		public static readonly AnimationParameter State_KatanaHeavyAttackWindup;

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x1A820")]
		public static readonly AnimationParameter State_KatanaIdle;

		// Token: 0x040009EE RID: 2542
		[Token(Token = "0x40009EE")]
		[FieldOffset(Offset = "0x1A850")]
		public static readonly AnimationParameter State_KatanaMove;

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x1A880")]
		public static readonly AnimationParameter State_KatanaParry;

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x1A8B0")]
		public static readonly AnimationParameter State_KeyCardEquip;

		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x1A8E0")]
		public static readonly AnimationParameter State_KeyCardFirstLook;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x1A910")]
		public static readonly AnimationParameter State_KeyCardIdle;

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x1A940")]
		public static readonly AnimationParameter State_KeyCardUnequip;

		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0x1A970")]
		public static readonly AnimationParameter State_KickAttackA;

		// Token: 0x040009F5 RID: 2549
		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x1A9A0")]
		public static readonly AnimationParameter State_KickAttackB;

		// Token: 0x040009F6 RID: 2550
		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0x1A9D0")]
		public static readonly AnimationParameter State_KickBodyA;

		// Token: 0x040009F7 RID: 2551
		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x1AA00")]
		public static readonly AnimationParameter State_KillerWhaleBiteAttack;

		// Token: 0x040009F8 RID: 2552
		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x1AA30")]
		public static readonly AnimationParameter State_KillerWhaleBiteAttackClose;

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x1AA60")]
		public static readonly AnimationParameter State_KillerWhaleDie;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x1AA90")]
		public static readonly AnimationParameter State_KillerWhaleEat;

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		[FieldOffset(Offset = "0x1AAC0")]
		public static readonly AnimationParameter State_KillerWhaleGetHit;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		[FieldOffset(Offset = "0x1AAF0")]
		public static readonly AnimationParameter State_KillerWhaleJumpOutOfWaterAttack;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		[FieldOffset(Offset = "0x1AB20")]
		public static readonly AnimationParameter State_KillerWhaleNudge;

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[FieldOffset(Offset = "0x1AB50")]
		public static readonly AnimationParameter State_KillerWhaleSwim;

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		[FieldOffset(Offset = "0x1AB80")]
		public static readonly AnimationParameter State_KillerWhaleSwimFast;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[FieldOffset(Offset = "0x1ABB0")]
		public static readonly AnimationParameter State_KillerWhaleTurnSharpLeft;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[FieldOffset(Offset = "0x1ABE0")]
		public static readonly AnimationParameter State_KillerWhaleTurnSharpRight;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		[FieldOffset(Offset = "0x1AC10")]
		public static readonly AnimationParameter State_KnifeBlockedLeftA;

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		[FieldOffset(Offset = "0x1AC40")]
		public static readonly AnimationParameter State_KnifeBlockedRightA;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		[FieldOffset(Offset = "0x1AC70")]
		public static readonly AnimationParameter State_KnifeSwingToLeftA;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[FieldOffset(Offset = "0x1ACA0")]
		public static readonly AnimationParameter State_KnifeSwingToLeftB;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[FieldOffset(Offset = "0x1ACD0")]
		public static readonly AnimationParameter State_KnifeSwingToRightA;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[FieldOffset(Offset = "0x1AD00")]
		public static readonly AnimationParameter State_KnifeSwingToRightB;

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		[FieldOffset(Offset = "0x1AD30")]
		public static readonly AnimationParameter State_KnightVEquip;

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		[FieldOffset(Offset = "0x1AD60")]
		public static readonly AnimationParameter State_KnightVFall;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		[FieldOffset(Offset = "0x1AD90")]
		public static readonly AnimationParameter State_KnightVIdle;

		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		[FieldOffset(Offset = "0x1ADC0")]
		public static readonly AnimationParameter State_KnightVIdleHeldToStand;

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x1ADF0")]
		public static readonly AnimationParameter State_KnightVIdleRideToStand;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x1AE20")]
		public static readonly AnimationParameter State_KnightVIdleStand;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x1AE50")]
		public static readonly AnimationParameter State_KnightVIdleStandToRide;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		[FieldOffset(Offset = "0x1AE80")]
		public static readonly AnimationParameter State_KnightVIHeldIdleToIdleStand;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		[FieldOffset(Offset = "0x1AEB0")]
		public static readonly AnimationParameter State_KnightVJump;

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		[FieldOffset(Offset = "0x1AEE0")]
		public static readonly AnimationParameter State_KnightVJumpStart;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		[FieldOffset(Offset = "0x1AF10")]
		public static readonly AnimationParameter State_KnightVLand;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0x1AF40")]
		public static readonly AnimationParameter State_KnightVRide;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		[FieldOffset(Offset = "0x1AF70")]
		public static readonly AnimationParameter State_KnightVUnequip;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		[FieldOffset(Offset = "0x1AFA0")]
		public static readonly AnimationParameter State_KnockdownBehind;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x1AFD0")]
		public static readonly AnimationParameter State_KnockdownFront;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x1B000")]
		public static readonly AnimationParameter State_KnockdownKnightVCrashForward;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x1B030")]
		public static readonly AnimationParameter State_KnockdownOnBackStandup;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x1B060")]
		public static readonly AnimationParameter State_KnockdownOnFrontStandup;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x1B090")]
		public static readonly AnimationParameter State_KnockOnDoor1;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x1B0C0")]
		public static readonly AnimationParameter State_KnockOnDoor2;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x1B0F0")]
		public static readonly AnimationParameter State_KnockoutBack;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x1B120")]
		public static readonly AnimationParameter State_KnockoutBackA;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x1B150")]
		public static readonly AnimationParameter State_KnockoutBackB;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x1B180")]
		public static readonly AnimationParameter State_KnockoutBackC;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x1B1B0")]
		public static readonly AnimationParameter State_LakeCrashBadGuyIntro;

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x1B1E0")]
		public static readonly AnimationParameter State_LakeCrashHelicopterCrash;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x1B210")]
		public static readonly AnimationParameter State_LakeCrashHelicopterEscape;

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x1B240")]
		public static readonly AnimationParameter State_LakeCrashHelicopterLookAtDoorLoop;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x1B270")]
		public static readonly AnimationParameter State_LakeCrashHelicopterLookAtDoorLoop_0;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x1B2A0")]
		public static readonly AnimationParameter State_LakeCrashPilot;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x1B2D0")]
		public static readonly AnimationParameter State_LakeCrashPlayerCrash;

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x1B300")]
		public static readonly AnimationParameter State_LakeCrashPlayerEscape;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x1B330")]
		public static readonly AnimationParameter State_LakeCrashPlayerKickDoorTry;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x1B360")]
		public static readonly AnimationParameter State_LakeCrashPlayerLookAtDoorLoop;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x1B390")]
		public static readonly AnimationParameter State_LakeCrashStandup;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x1B3C0")]
		public static readonly AnimationParameter State_LakeCrashTactiA;

		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0x1B3F0")]
		public static readonly AnimationParameter State_LakeCrashTactiB;

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x1B420")]
		public static readonly AnimationParameter State_Land;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x1B450")]
		public static readonly AnimationParameter State_landHeavy;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0x1B480")]
		public static readonly AnimationParameter State_landLight;

		// Token: 0x04000A30 RID: 2608
		[Token(Token = "0x4000A30")]
		[FieldOffset(Offset = "0x1B4B0")]
		public static readonly AnimationParameter State_LaserMeasureToolCraftEmptyBag;

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0x1B4E0")]
		public static readonly AnimationParameter State_LaserMeasureToolIdle;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		[FieldOffset(Offset = "0x1B510")]
		public static readonly AnimationParameter State_laserPointerIdle;

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0x1B540")]
		public static readonly AnimationParameter State_LaserSightModCraftCompactPistolLaserSightMod;

		// Token: 0x04000A34 RID: 2612
		[Token(Token = "0x4000A34")]
		[FieldOffset(Offset = "0x1B570")]
		public static readonly AnimationParameter State_LaserSightModCraftCrossbowLaserSightMod;

		// Token: 0x04000A35 RID: 2613
		[Token(Token = "0x4000A35")]
		[FieldOffset(Offset = "0x1B5A0")]
		public static readonly AnimationParameter State_LaserSightModCraftShotgunPumpActionLaserSightMod;

		// Token: 0x04000A36 RID: 2614
		[Token(Token = "0x4000A36")]
		[FieldOffset(Offset = "0x1B5D0")]
		public static readonly AnimationParameter State_LaserSightModIdle;

		// Token: 0x04000A37 RID: 2615
		[Token(Token = "0x4000A37")]
		[FieldOffset(Offset = "0x1B600")]
		public static readonly AnimationParameter State_LaughWithPlayer;

		// Token: 0x04000A38 RID: 2616
		[Token(Token = "0x4000A38")]
		[FieldOffset(Offset = "0x1B630")]
		public static readonly AnimationParameter State_LayToIdle;

		// Token: 0x04000A39 RID: 2617
		[Token(Token = "0x4000A39")]
		[FieldOffset(Offset = "0x1B660")]
		public static readonly AnimationParameter State_LeafACraftCraftedLeafArmor;

		// Token: 0x04000A3A RID: 2618
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0x1B690")]
		public static readonly AnimationParameter State_LeafArmourCraftCraftedLeafArmor;

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x1B6C0")]
		public static readonly AnimationParameter State_LeafArmourIdle;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x1B6F0")]
		public static readonly AnimationParameter State_LeafBCraftCraftedLeafArmor;

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x1B720")]
		public static readonly AnimationParameter State_LeafCCraftCraftedLeafArmor;

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x1B750")]
		public static readonly AnimationParameter State_LeafCraftCraftedLeafArmor;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x1B780")]
		public static readonly AnimationParameter State_LeafDCraftCraftedLeafArmor;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x1B7B0")]
		public static readonly AnimationParameter State_LeafECraftCraftedLeafArmor;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x1B7E0")]
		public static readonly AnimationParameter State_LeafFCraftCraftedLeafArmor;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x1B810")]
		public static readonly AnimationParameter State_LeafGCraftCraftedLeafArmor;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x1B840")]
		public static readonly AnimationParameter State_LeafHCraftCraftedLeafArmor;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x1B870")]
		public static readonly AnimationParameter State_LeafICraftCraftedLeafArmor;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x1B8A0")]
		public static readonly AnimationParameter State_LeafIdle;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x1B8D0")]
		public static readonly AnimationParameter State_LeafJCraftCraftedLeafArmor;

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x1B900")]
		public static readonly AnimationParameter State_leanBack;

		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x1B930")]
		public static readonly AnimationParameter State_LeanForward;

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0x1B960")]
		public static readonly AnimationParameter State_LeapAttack;

		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4000A4A")]
		[FieldOffset(Offset = "0x1B990")]
		public static readonly AnimationParameter State_LeapAttackIntro;

		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4000A4B")]
		[FieldOffset(Offset = "0x1B9C0")]
		public static readonly AnimationParameter State_LeapOffRockAttack;

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		[FieldOffset(Offset = "0x1B9F0")]
		public static readonly AnimationParameter State_Left;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x1BA20")]
		public static readonly AnimationParameter State_LegSwipeLeftA;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x1BA50")]
		public static readonly AnimationParameter State_LegSwipeRightA;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0x1BA80")]
		public static readonly AnimationParameter State_LieDownToSleepA;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x1BAB0")]
		public static readonly AnimationParameter State_LieDownToSleepB;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x1BAE0")]
		public static readonly AnimationParameter State_LieDownToSleepBed;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		[FieldOffset(Offset = "0x1BB10")]
		public static readonly AnimationParameter State_LiftPilarUnderBeam;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x1BB40")]
		public static readonly AnimationParameter State_lightBow;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x1BB70")]
		public static readonly AnimationParameter State_LightClub;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x1BBA0")]
		public static readonly AnimationParameter State_lightClub;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x1BBD0")]
		public static readonly AnimationParameter State_LighterCrossbowAimIdle;

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x1BC00")]
		public static readonly AnimationParameter State_LighterEmailHeldIdle;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[FieldOffset(Offset = "0x1BC30")]
		public static readonly AnimationParameter State_LighterEmailReadIlde;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[FieldOffset(Offset = "0x1BC60")]
		public static readonly AnimationParameter State_LighterIdle;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[FieldOffset(Offset = "0x1BC90")]
		public static readonly AnimationParameter State_lighterIdle;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		[FieldOffset(Offset = "0x1BCC0")]
		public static readonly AnimationParameter State_LighterIdleExtraWide;

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[FieldOffset(Offset = "0x1BCF0")]
		public static readonly AnimationParameter State_LighterIdleHeldGliderFly;

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[FieldOffset(Offset = "0x1BD20")]
		public static readonly AnimationParameter State_LighterIdleHeldGliderStand;

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		[FieldOffset(Offset = "0x1BD50")]
		public static readonly AnimationParameter State_LighterIdleRopegun;

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x1BD80")]
		public static readonly AnimationParameter State_LighterIdleToIdle;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x1BDB0")]
		public static readonly AnimationParameter State_LighterIdleWide;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x1BDE0")]
		public static readonly AnimationParameter State_LighterLookAt;

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x1BE10")]
		public static readonly AnimationParameter State_LighterSlideDown;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x1BE40")]
		public static readonly AnimationParameter State_LighterStickBreakKneeToLightFirePrompt;

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x1BE70")]
		public static readonly AnimationParameter State_lightMolotov;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x1BEA0")]
		public static readonly AnimationParameter State_LightMolotov;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x1BED0")]
		public static readonly AnimationParameter State_lightTacticalBow;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x1BF00")]
		public static readonly AnimationParameter State_lightWeapon;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x1BF30")]
		public static readonly AnimationParameter State_LightWind;

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x1BF60")]
		public static readonly AnimationParameter State_LimpIdle;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x1BF90")]
		public static readonly AnimationParameter State_LimpIdleToWalkAggressive;

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x1BFC0")]
		public static readonly AnimationParameter State_LimpPassthrough;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x1BFF0")]
		public static readonly AnimationParameter State_LimpTurnAroundFast;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x1C020")]
		public static readonly AnimationParameter State_LimpTurnLeftFast;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x1C050")]
		public static readonly AnimationParameter State_LimpTurnRightFast;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x1C080")]
		public static readonly AnimationParameter State_LimpWalkAggressive;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x1C0B0")]
		public static readonly AnimationParameter State_LimpWalkAggressiveToIdle;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x1C0E0")]
		public static readonly AnimationParameter State_LimpWalkToTurn180;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x1C110")]
		public static readonly AnimationParameter State_LimpWalkToTurnLeft;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x1C140")]
		public static readonly AnimationParameter State_LimpWalkToTurnRight;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x1C170")]
		public static readonly AnimationParameter State_load;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0x1C1A0")]
		public static readonly AnimationParameter State_loadIdle;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		[FieldOffset(Offset = "0x1C1D0")]
		public static readonly AnimationParameter State_locomotion;

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		[FieldOffset(Offset = "0x1C200")]
		public static readonly AnimationParameter State_Locomotion;

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x1C230")]
		public static readonly AnimationParameter State_locomotionLogSled;

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x1C260")]
		public static readonly AnimationParameter State_locomotionMP;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0x1C290")]
		public static readonly AnimationParameter State_LogSledConnected;

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x1C2C0")]
		public static readonly AnimationParameter State_LogSledIdle;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x1C2F0")]
		public static readonly AnimationParameter State_LookAround180A;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x1C320")]
		public static readonly AnimationParameter State_LookAround180B;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x1C350")]
		public static readonly AnimationParameter State_LookAroundBothSidesIntro;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x1C380")]
		public static readonly AnimationParameter State_LookAroundBothSidesOutro;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x1C3B0")]
		public static readonly AnimationParameter State_LookAroundLeftA;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x1C3E0")]
		public static readonly AnimationParameter State_LookAroundLeftB;

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x1C410")]
		public static readonly AnimationParameter State_LookAroundRightA;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x1C440")]
		public static readonly AnimationParameter State_LookAroundRightB;

		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		[FieldOffset(Offset = "0x1C470")]
		public static readonly AnimationParameter State_lookAtPhoto;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x1C4A0")]
		public static readonly AnimationParameter State_lookAtPhotoLoop;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x1C4D0")]
		public static readonly AnimationParameter State_lookItemLoop;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x1C500")]
		public static readonly AnimationParameter State_lookItemRightLoop;

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x1C530")]
		public static readonly AnimationParameter State_lookItemRightToIdle;

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x1C560")]
		public static readonly AnimationParameter State_lookItemToIdle;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x1C590")]
		public static readonly AnimationParameter State_lookLeftToIdle;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x1C5C0")]
		public static readonly AnimationParameter State_lookRightToIdle;

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		[FieldOffset(Offset = "0x1C5F0")]
		public static readonly AnimationParameter State_LootPouchCraftLootPouch;

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		[FieldOffset(Offset = "0x1C620")]
		public static readonly AnimationParameter State_LootPouchIdle;

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x1C650")]
		public static readonly AnimationParameter State_LoudNoiseReaction01;

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0x1C680")]
		public static readonly AnimationParameter State_LoudNoiseReaction02;

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x1C6B0")]
		public static readonly AnimationParameter State_LoudNoiseReaction03;

		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x1C6E0")]
		public static readonly AnimationParameter State_LowAttack;

		// Token: 0x04000A92 RID: 2706
		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x1C710")]
		public static readonly AnimationParameter State_LungeAttack;

		// Token: 0x04000A93 RID: 2707
		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x1C740")]
		public static readonly AnimationParameter State_LungeAttackA;

		// Token: 0x04000A94 RID: 2708
		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x1C770")]
		public static readonly AnimationParameter State_LungeAttackB;

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0x1C7A0")]
		public static readonly AnimationParameter State_LungeAttackC;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0x1C7D0")]
		public static readonly AnimationParameter State_LungeAttackD;

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x1C800")]
		public static readonly AnimationParameter State_MacheteBlock1;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[FieldOffset(Offset = "0x1C830")]
		public static readonly AnimationParameter State_MacheteBlock2;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		[FieldOffset(Offset = "0x1C860")]
		public static readonly AnimationParameter State_MacheteBlockedLeftA;

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x1C890")]
		public static readonly AnimationParameter State_MacheteBlockedRightA;

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x1C8C0")]
		public static readonly AnimationParameter State_MacheteBlockHit1;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x1C8F0")]
		public static readonly AnimationParameter State_MacheteBlockHit2;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0x1C920")]
		public static readonly AnimationParameter State_MacheteBlockToIdle;

		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		[FieldOffset(Offset = "0x1C950")]
		public static readonly AnimationParameter State_MacheteEquip;

		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		[FieldOffset(Offset = "0x1C980")]
		public static readonly AnimationParameter State_MacheteFirstLook;

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[FieldOffset(Offset = "0x1C9B0")]
		public static readonly AnimationParameter State_MacheteGround1;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[FieldOffset(Offset = "0x1C9E0")]
		public static readonly AnimationParameter State_MacheteGroundToGroundAttack;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		[FieldOffset(Offset = "0x1CA10")]
		public static readonly AnimationParameter State_MacheteHeavyAttack;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		[FieldOffset(Offset = "0x1CA40")]
		public static readonly AnimationParameter State_MacheteHeavyAttackWindup;

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4000AA4")]
		[FieldOffset(Offset = "0x1CA70")]
		public static readonly AnimationParameter State_MacheteIdleHeld;

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x1CAA0")]
		public static readonly AnimationParameter State_MacheteParry;

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		[FieldOffset(Offset = "0x1CAD0")]
		public static readonly AnimationParameter State_MacheteSlashLeftAttack;

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x1CB00")]
		public static readonly AnimationParameter State_MacheteSlashRightAttack;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x1CB30")]
		public static readonly AnimationParameter State_Main;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x1CB60")]
		public static readonly AnimationParameter State_MainMenuButtonHighlight;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x1CB90")]
		public static readonly AnimationParameter State_MainMenuButtonHighlightLoop;

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x1CBC0")]
		public static readonly AnimationParameter State_MainMenuButtonNormalLoop;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x1CBF0")]
		public static readonly AnimationParameter State_MakeNest;

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		[FieldOffset(Offset = "0x1CC20")]
		public static readonly AnimationParameter State_mapRaise;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x1CC50")]
		public static readonly AnimationParameter State_mapRaise_0;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		[FieldOffset(Offset = "0x1CC80")]
		public static readonly AnimationParameter State_mapRaiseIdle;

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x1CCB0")]
		public static readonly AnimationParameter State_MaskEquip;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x1CCE0")]
		public static readonly AnimationParameter State_MaskFirstLook;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x1CD10")]
		public static readonly AnimationParameter State_MaskIdle;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x1CD40")]
		public static readonly AnimationParameter State_MaskIdleToWear;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x1CD70")]
		public static readonly AnimationParameter State_MaskPickup;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x1CDA0")]
		public static readonly AnimationParameter State_MaskUnequip;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x1CDD0")]
		public static readonly AnimationParameter State_MaskWear;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x1CE00")]
		public static readonly AnimationParameter State_MaskWearToIdle;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x1CE30")]
		public static readonly AnimationParameter State_meetZombieBoy;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x1CE60")]
		public static readonly AnimationParameter State_MessagePulse;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x1CE90")]
		public static readonly AnimationParameter State_Modal_Window_In;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0x1CEC0")]
		public static readonly AnimationParameter State_Modal_Window_Out;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x1CEF0")]
		public static readonly AnimationParameter State_Modal_Window_Start;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x1CF20")]
		public static readonly AnimationParameter State_MolotovCraftMolotov;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x1CF50")]
		public static readonly AnimationParameter State_MolotovIdle;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x1CF80")]
		public static readonly AnimationParameter State_molotovIdle;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x1CFB0")]
		public static readonly AnimationParameter State_molotovThrow;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x1CFE0")]
		public static readonly AnimationParameter State_MoneyCraftLootPouch;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x1D010")]
		public static readonly AnimationParameter State_MoneyIdle;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[FieldOffset(Offset = "0x1D040")]
		public static readonly AnimationParameter State_MooseStepBack;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[FieldOffset(Offset = "0x1D070")]
		public static readonly AnimationParameter State_MournBody;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0x1D0A0")]
		public static readonly AnimationParameter State_MournBodyA;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x1D0D0")]
		public static readonly AnimationParameter State_MournBodyB;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x1D100")]
		public static readonly AnimationParameter State_MoveClub;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x1D130")]
		public static readonly AnimationParameter State_MoveClubMP;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x1D160")]
		public static readonly AnimationParameter State_MoveKnife;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x1D190")]
		public static readonly AnimationParameter State_MoveMachete;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x1D1C0")]
		public static readonly AnimationParameter State_MoveRepairTool;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x1D1F0")]
		public static readonly AnimationParameter State_MoveStick;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x1D220")]
		public static readonly AnimationParameter State_MoveStickMP;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x1D250")]
		public static readonly AnimationParameter State_MoveTacticalAxe;

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x1D280")]
		public static readonly AnimationParameter State_MrePackCraftFoodTrayFilled;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x1D2B0")]
		public static readonly AnimationParameter State_MrePackIdle;

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0x1D2E0")]
		public static readonly AnimationParameter State_MrPuffyCapturedAgitated;

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x1D310")]
		public static readonly AnimationParameter State_MrPuffyCapturedIdle;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x1D340")]
		public static readonly AnimationParameter State_MuddyTreeTaunt;

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x1D370")]
		public static readonly AnimationParameter State_Mutant1Dragaway;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x1D3A0")]
		public static readonly AnimationParameter State_Mutant2Dragaway;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x1D3D0")]
		public static readonly AnimationParameter State_MutantDemonAttackA;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[FieldOffset(Offset = "0x1D400")]
		public static readonly AnimationParameter State_MutantDemonAttackALeftArm;

		// Token: 0x04000AD8 RID: 2776
		[Token(Token = "0x4000AD8")]
		[FieldOffset(Offset = "0x1D430")]
		public static readonly AnimationParameter State_MutantDemonAttackARightArm;

		// Token: 0x04000AD9 RID: 2777
		[Token(Token = "0x4000AD9")]
		[FieldOffset(Offset = "0x1D460")]
		public static readonly AnimationParameter State_MutantDemonAttackB;

		// Token: 0x04000ADA RID: 2778
		[Token(Token = "0x4000ADA")]
		[FieldOffset(Offset = "0x1D490")]
		public static readonly AnimationParameter State_NegativeReactionBig;

		// Token: 0x04000ADB RID: 2779
		[Token(Token = "0x4000ADB")]
		[FieldOffset(Offset = "0x1D4C0")]
		public static readonly AnimationParameter State_NetworkPassThrough;

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		[FieldOffset(Offset = "0x1D4F0")]
		public static readonly AnimationParameter State_New_State;

		// Token: 0x04000ADD RID: 2781
		[Token(Token = "0x4000ADD")]
		[FieldOffset(Offset = "0x1D520")]
		public static readonly AnimationParameter State_NewRecipeExclamationPulse;

		// Token: 0x04000ADE RID: 2782
		[Token(Token = "0x4000ADE")]
		[FieldOffset(Offset = "0x1D550")]
		public static readonly AnimationParameter State_No_Animation_1;

		// Token: 0x04000ADF RID: 2783
		[Token(Token = "0x4000ADF")]
		[FieldOffset(Offset = "0x1D580")]
		public static readonly AnimationParameter State_No_Animation_2;

		// Token: 0x04000AE0 RID: 2784
		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0x1D5B0")]
		public static readonly AnimationParameter State_noBatteryShake;

		// Token: 0x04000AE1 RID: 2785
		[Token(Token = "0x4000AE1")]
		[FieldOffset(Offset = "0x1D5E0")]
		public static readonly AnimationParameter State_NodHead;

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0x1D610")]
		public static readonly AnimationParameter State_NoiseReact180;

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x1D640")]
		public static readonly AnimationParameter State_NoiseReactLeft;

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x1D670")]
		public static readonly AnimationParameter State_NoiseReactRight;

		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4000AE5")]
		[FieldOffset(Offset = "0x1D6A0")]
		public static readonly AnimationParameter State_None;

		// Token: 0x04000AE6 RID: 2790
		[Token(Token = "0x4000AE6")]
		[FieldOffset(Offset = "0x1D6D0")]
		public static readonly AnimationParameter State_NONE;

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		[FieldOffset(Offset = "0x1D700")]
		public static readonly AnimationParameter State_Normal;

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		[FieldOffset(Offset = "0x1D730")]
		public static readonly AnimationParameter State_Normal_to_Hover;

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0x1D760")]
		public static readonly AnimationParameter State_Nudge;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x1D790")]
		public static readonly AnimationParameter State_OnBackDeath;

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x1D7C0")]
		public static readonly AnimationParameter State_OnFire;

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0x1D7F0")]
		public static readonly AnimationParameter State_OnLadderClimbDown;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x1D820")]
		public static readonly AnimationParameter State_OnLadderClimbUp;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x1D850")]
		public static readonly AnimationParameter State_OnLadderExitAtTop;

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x1D880")]
		public static readonly AnimationParameter State_OnLadderIdle;

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x1D8B0")]
		public static readonly AnimationParameter State_OnRockIdle;

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x1D8E0")]
		public static readonly AnimationParameter State_OnRockTurnLeft;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x1D910")]
		public static readonly AnimationParameter State_OnRockTurnLeft180;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x1D940")]
		public static readonly AnimationParameter State_OnRockTurnRight;

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[FieldOffset(Offset = "0x1D970")]
		public static readonly AnimationParameter State_OnStomachDeath;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[FieldOffset(Offset = "0x1D9A0")]
		public static readonly AnimationParameter State_OnTreeIdle;

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		[FieldOffset(Offset = "0x1D9D0")]
		public static readonly AnimationParameter State_open;

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		[FieldOffset(Offset = "0x1DA00")]
		public static readonly AnimationParameter State_OpenCase;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x1DA30")]
		public static readonly AnimationParameter State_OpenDoorIdle;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x1DA60")]
		public static readonly AnimationParameter State_OpenHatch;

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x1DA90")]
		public static readonly AnimationParameter State_OpenHatchNoWipe;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x1DAC0")]
		public static readonly AnimationParameter State_OpenHellDoor;

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x1DAF0")]
		public static readonly AnimationParameter State_OpenIdle;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0x1DB20")]
		public static readonly AnimationParameter State_openKeypadDoor;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0x1DB50")]
		public static readonly AnimationParameter State_OpenSecurityDoor;

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0x1DB80")]
		public static readonly AnimationParameter State_openStatic;

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x1DBB0")]
		public static readonly AnimationParameter State_operatePanel;

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x1DBE0")]
		public static readonly AnimationParameter State_operatePanelExit;

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0x1DC10")]
		public static readonly AnimationParameter State_Out;

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0x1DC40")]
		public static readonly AnimationParameter State_Outro;

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x1DC70")]
		public static readonly AnimationParameter State_OysterCraftLootPouch;

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0x1DCA0")]
		public static readonly AnimationParameter State_OysterIdle;

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x1DCD0")]
		public static readonly AnimationParameter State_paddleIdle;

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x1DD00")]
		public static readonly AnimationParameter State_paddleIdleToPaddle;

		// Token: 0x04000B08 RID: 2824
		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x1DD30")]
		public static readonly AnimationParameter State_paddleLoop;

		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0x1DD60")]
		public static readonly AnimationParameter State_Panel_In;

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x1DD90")]
		public static readonly AnimationParameter State_Panel_Out;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x1DDC0")]
		public static readonly AnimationParameter State_PaperTargetEquip;

		// Token: 0x04000B0C RID: 2828
		[Token(Token = "0x4000B0C")]
		[FieldOffset(Offset = "0x1DDF0")]
		public static readonly AnimationParameter State_PaperTargetIdle;

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x1DE20")]
		public static readonly AnimationParameter State_PaperTargetPlace;

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		[FieldOffset(Offset = "0x1DE50")]
		public static readonly AnimationParameter State_PaperTargetUnequip;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x1DE80")]
		public static readonly AnimationParameter State_ParryReactA;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x1DEB0")]
		public static readonly AnimationParameter State_part1;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x1DEE0")]
		public static readonly AnimationParameter State_part2Debris;

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x1DF10")]
		public static readonly AnimationParameter State_passenger_flyBack1;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x1DF40")]
		public static readonly AnimationParameter State_passengerFallForward;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x1DF70")]
		public static readonly AnimationParameter State_passengerFallForward_0;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x1DFA0")]
		public static readonly AnimationParameter State_passengerFallForward_1;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x1DFD0")]
		public static readonly AnimationParameter State_passengerIdle1;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x1E000")]
		public static readonly AnimationParameter State_passengerIdle2;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x1E030")]
		public static readonly AnimationParameter State_passengerIdle3;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[FieldOffset(Offset = "0x1E060")]
		public static readonly AnimationParameter State_passengerIdlecrash1;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x1E090")]
		public static readonly AnimationParameter State_passengerIdlecrash1_0;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x1E0C0")]
		public static readonly AnimationParameter State_passengerIdlecrash1_1;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0x1E0F0")]
		public static readonly AnimationParameter State_PassThrough;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x1E120")]
		public static readonly AnimationParameter State_PausedCooking;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x1E150")]
		public static readonly AnimationParameter State_pedometerIdle;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x1E180")]
		public static readonly AnimationParameter State_PeekAroundTree;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0x1E1B0")]
		public static readonly AnimationParameter State_photoIdle;

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x1E1E0")]
		public static readonly AnimationParameter State_photoToIdle;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x1E210")]
		public static readonly AnimationParameter State_PickUp;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x1E240")]
		public static readonly AnimationParameter State_PickUpBag;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0x1E270")]
		public static readonly AnimationParameter State_PickUpBags;

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0x1E2A0")]
		public static readonly AnimationParameter State_PickupBerries;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		[FieldOffset(Offset = "0x1E2D0")]
		public static readonly AnimationParameter State_pickupBook;

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4000B27")]
		[FieldOffset(Offset = "0x1E300")]
		public static readonly AnimationParameter State_PickupFirstRock;

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4000B28")]
		[FieldOffset(Offset = "0x1E330")]
		public static readonly AnimationParameter State_PickupFirstStick;

		// Token: 0x04000B29 RID: 2857
		[Token(Token = "0x4000B29")]
		[FieldOffset(Offset = "0x1E360")]
		public static readonly AnimationParameter State_PickupFromGround;

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0x1E390")]
		public static readonly AnimationParameter State_PickupLog;

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4000B2B")]
		[FieldOffset(Offset = "0x1E3C0")]
		public static readonly AnimationParameter State_PickupRadio;

		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4000B2C")]
		[FieldOffset(Offset = "0x1E3F0")]
		public static readonly AnimationParameter State_PickupRock;

		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4000B2D")]
		[FieldOffset(Offset = "0x1E420")]
		public static readonly AnimationParameter State_PickupSecondLog;

		// Token: 0x04000B2E RID: 2862
		[Token(Token = "0x4000B2E")]
		[FieldOffset(Offset = "0x1E450")]
		public static readonly AnimationParameter State_PickupStick;

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4000B2F")]
		[FieldOffset(Offset = "0x1E480")]
		public static readonly AnimationParameter State_PickupThrowBody;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4000B30")]
		[FieldOffset(Offset = "0x1E4B0")]
		public static readonly AnimationParameter State_PillsCraftLootPouch;

		// Token: 0x04000B31 RID: 2865
		[Token(Token = "0x4000B31")]
		[FieldOffset(Offset = "0x1E4E0")]
		public static readonly AnimationParameter State_PillsIdle;

		// Token: 0x04000B32 RID: 2866
		[Token(Token = "0x4000B32")]
		[FieldOffset(Offset = "0x1E510")]
		public static readonly AnimationParameter State_pinchGrab;

		// Token: 0x04000B33 RID: 2867
		[Token(Token = "0x4000B33")]
		[FieldOffset(Offset = "0x1E540")]
		public static readonly AnimationParameter State_PistolAim;

		// Token: 0x04000B34 RID: 2868
		[Token(Token = "0x4000B34")]
		[FieldOffset(Offset = "0x1E570")]
		public static readonly AnimationParameter State_pistolAimForward;

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4000B35")]
		[FieldOffset(Offset = "0x1E5A0")]
		public static readonly AnimationParameter State_pistolAimToIdle;

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		[FieldOffset(Offset = "0x1E5D0")]
		public static readonly AnimationParameter State_PistolAnim_DryFire;

		// Token: 0x04000B37 RID: 2871
		[Token(Token = "0x4000B37")]
		[FieldOffset(Offset = "0x1E600")]
		public static readonly AnimationParameter State_PistolAnim_EmptyIdle;

		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x1E630")]
		public static readonly AnimationParameter State_PistolAnim_Fire;

		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x1E660")]
		public static readonly AnimationParameter State_PistolAnim_FireLast;

		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x1E690")]
		public static readonly AnimationParameter State_PistolAnim_GearUpEquip;

		// Token: 0x04000B3B RID: 2875
		[Token(Token = "0x4000B3B")]
		[FieldOffset(Offset = "0x1E6C0")]
		public static readonly AnimationParameter State_PistolAnim_IdleHeld;

		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x1E6F0")]
		public static readonly AnimationParameter State_PistolAnim_Reload;

		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0x1E720")]
		public static readonly AnimationParameter State_PistolEquip;

		// Token: 0x04000B3E RID: 2878
		[Token(Token = "0x4000B3E")]
		[FieldOffset(Offset = "0x1E750")]
		public static readonly AnimationParameter State_pistolFire;

		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x4000B3F")]
		[FieldOffset(Offset = "0x1E780")]
		public static readonly AnimationParameter State_PistolIdle;

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x1E7B0")]
		public static readonly AnimationParameter State_PistolShoot;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0x1E7E0")]
		public static readonly AnimationParameter State_PistolSuppressorCraftCompactPistolPistolSuppressor;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0x1E810")]
		public static readonly AnimationParameter State_PistolSuppressorIdle;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0x1E840")]
		public static readonly AnimationParameter State_PistolUnequip;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x1E870")]
		public static readonly AnimationParameter State_PlaceFloorIdle;

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x1E8A0")]
		public static readonly AnimationParameter State_placeFloorIdle;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0x1E8D0")]
		public static readonly AnimationParameter State_PlaceFloorIdleR;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x1E900")]
		public static readonly AnimationParameter State_PlaceFloorIdleToCarry;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x1E930")]
		public static readonly AnimationParameter State_PlaceFloorIdleToCarryR;

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		[FieldOffset(Offset = "0x1E960")]
		public static readonly AnimationParameter State_placeFloorToIdle;

		// Token: 0x04000B4A RID: 2890
		[Token(Token = "0x4000B4A")]
		[FieldOffset(Offset = "0x1E990")]
		public static readonly AnimationParameter State_PlaceFloorToIdle;

		// Token: 0x04000B4B RID: 2891
		[Token(Token = "0x4000B4B")]
		[FieldOffset(Offset = "0x1E9C0")]
		public static readonly AnimationParameter State_PlaceFloorToIdleR;

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		[FieldOffset(Offset = "0x1E9F0")]
		public static readonly AnimationParameter State_PlaceHorizontalIdle;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		[FieldOffset(Offset = "0x1EA20")]
		public static readonly AnimationParameter State_PlaceHorizontalIdleR;

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4000B4E")]
		[FieldOffset(Offset = "0x1EA50")]
		public static readonly AnimationParameter State_PlaceHorizontalIdleToCarry;

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		[FieldOffset(Offset = "0x1EA80")]
		public static readonly AnimationParameter State_PlaceHorizontalIdleToCarryR;

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4000B50")]
		[FieldOffset(Offset = "0x1EAB0")]
		public static readonly AnimationParameter State_PlaceHorizontalToIdle;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0x1EAE0")]
		public static readonly AnimationParameter State_PlaceHorizontalToIdleR;

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x1EB10")]
		public static readonly AnimationParameter State_PlaceLog;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x1EB40")]
		public static readonly AnimationParameter State_placeLogFlat;

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x1EB70")]
		public static readonly AnimationParameter State_placeLogToIdle;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x1EBA0")]
		public static readonly AnimationParameter State_PlacePilarUnderBeamPushToIdle;

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x1EBD0")]
		public static readonly AnimationParameter State_placePilarUnderBeamToIdle;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x1EC00")]
		public static readonly AnimationParameter State_PlacePilarUnderBeamToIdle;

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x1EC30")]
		public static readonly AnimationParameter State_PlacePilarUnderBeamToIdleR;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x1EC60")]
		public static readonly AnimationParameter State_PlacePilarUnderBeamV2ToIdle;

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0x1EC90")]
		public static readonly AnimationParameter State_PlacePillar;

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x1ECC0")]
		public static readonly AnimationParameter State_PlaceRock;

		// Token: 0x04000B5C RID: 2908
		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0x1ECF0")]
		public static readonly AnimationParameter State_PlaceStick;

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x1ED20")]
		public static readonly AnimationParameter State_PlaceStrut;

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0x1ED50")]
		public static readonly AnimationParameter State_PlaceStrutOpposite;

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x1ED80")]
		public static readonly AnimationParameter State_PlaceTarp;

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x1EDB0")]
		public static readonly AnimationParameter State_PlaceTarpStake;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x1EDE0")]
		public static readonly AnimationParameter State_planeFallAll;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x1EE10")]
		public static readonly AnimationParameter State_PlantNTurnLeft;

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x1EE40")]
		public static readonly AnimationParameter State_PlantNTurnRight;

		// Token: 0x04000B64 RID: 2916
		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x1EE70")]
		public static readonly AnimationParameter State_PlantPilar;

		// Token: 0x04000B65 RID: 2917
		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x1EEA0")]
		public static readonly AnimationParameter State_PlantPilarToIdle;

		// Token: 0x04000B66 RID: 2918
		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x1EED0")]
		public static readonly AnimationParameter State_PlantPilarToIdleR;

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x1EF00")]
		public static readonly AnimationParameter State_PlasmaLighterCraftEmptyBag;

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x1EF30")]
		public static readonly AnimationParameter State_PlasmaLighterIdle;

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x1EF60")]
		public static readonly AnimationParameter State_PlayerABunkerPamphletFirstLook;

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x1EF90")]
		public static readonly AnimationParameter State_PlayerABunkerPamphletIdle;

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x1EFC0")]
		public static readonly AnimationParameter State_PlayerACaveEnter;

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x1EFF0")]
		public static readonly AnimationParameter State_PlayerACaveExit;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x1F020")]
		public static readonly AnimationParameter State_PlayerACraftBoneArmor;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0x1F050")]
		public static readonly AnimationParameter State_PlayerACraftCatFood;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0x1F080")]
		public static readonly AnimationParameter State_PlayerACraftClothingA;

		// Token: 0x04000B70 RID: 2928
		[Token(Token = "0x4000B70")]
		[FieldOffset(Offset = "0x1F0B0")]
		public static readonly AnimationParameter State_PlayerACraftClothingB;

		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0x1F0E0")]
		public static readonly AnimationParameter State_PlayerACraftClothingC;

		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x1F110")]
		public static readonly AnimationParameter State_PlayerACraftClothingFastA;

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x1F140")]
		public static readonly AnimationParameter State_PlayerACraftClothingFastB;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x1F170")]
		public static readonly AnimationParameter State_PlayerACraftClothingFastC;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x1F1A0")]
		public static readonly AnimationParameter State_PlayerACraftClothingLower;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x1F1D0")]
		public static readonly AnimationParameter State_PlayerACraftClothingUpperA;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x1F200")]
		public static readonly AnimationParameter State_PlayerACraftClothingUpperB;

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x1F230")]
		public static readonly AnimationParameter State_PlayerACraftCompactPistolCompactPistolRail;

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x1F260")]
		public static readonly AnimationParameter State_PlayerACraftCompactPistolFlashlightMod;

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		[FieldOffset(Offset = "0x1F290")]
		public static readonly AnimationParameter State_PlayerACraftCompactPistolLaserSightMod;

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		[FieldOffset(Offset = "0x1F2C0")]
		public static readonly AnimationParameter State_PlayerACraftCompactPistolPistolSuppressor;

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		[FieldOffset(Offset = "0x1F2F0")]
		public static readonly AnimationParameter State_PlayerACraftCompactPistolScopeMod;

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		[FieldOffset(Offset = "0x1F320")]
		public static readonly AnimationParameter State_PlayerACraftCraftedArrows;

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		[FieldOffset(Offset = "0x1F350")]
		public static readonly AnimationParameter State_PlayerACraftCraftedAxe;

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		[FieldOffset(Offset = "0x1F380")]
		public static readonly AnimationParameter State_PlayerACraftCraftedBow;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x1F3B0")]
		public static readonly AnimationParameter State_PlayerACraftCraftedClub;

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		[FieldOffset(Offset = "0x1F3E0")]
		public static readonly AnimationParameter State_PlayerACraftCraftedLeafArmor;

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		[FieldOffset(Offset = "0x1F410")]
		public static readonly AnimationParameter State_PlayerACraftCraftedSpear;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x1F440")]
		public static readonly AnimationParameter State_PlayerACraftCraftedTorch;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x1F470")]
		public static readonly AnimationParameter State_PlayerACraftCrossbowFlashlightMod;

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x1F4A0")]
		public static readonly AnimationParameter State_PlayerACraftCrossbowLaserSightMod;

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0x1F4D0")]
		public static readonly AnimationParameter State_PlayerACraftCrossbowScope;

		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4000B87")]
		[FieldOffset(Offset = "0x1F500")]
		public static readonly AnimationParameter State_PlayerACraftDeerHideArmour;

		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4000B88")]
		[FieldOffset(Offset = "0x1F530")]
		public static readonly AnimationParameter State_PlayerACraftEmptyBag;

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		[FieldOffset(Offset = "0x1F560")]
		public static readonly AnimationParameter State_PlayerACraftFoodTrayFilled;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		[FieldOffset(Offset = "0x1F590")]
		public static readonly AnimationParameter State_PlayerACraftHerbMix;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x1F5C0")]
		public static readonly AnimationParameter State_PlayerACraftLootPouch;

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x1F5F0")]
		public static readonly AnimationParameter State_PlayerACraftMed;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x1F620")]
		public static readonly AnimationParameter State_PlayerACraftMolotov;

		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4000B8E")]
		[FieldOffset(Offset = "0x1F650")]
		public static readonly AnimationParameter State_PlayerACraftShotgunPumpActionFlashlightMod;

		// Token: 0x04000B8F RID: 2959
		[Token(Token = "0x4000B8F")]
		[FieldOffset(Offset = "0x1F680")]
		public static readonly AnimationParameter State_PlayerACraftShotgunPumpActionLaserSightMod;

		// Token: 0x04000B90 RID: 2960
		[Token(Token = "0x4000B90")]
		[FieldOffset(Offset = "0x1F6B0")]
		public static readonly AnimationParameter State_PlayerACraftShotgunPumpActionScopeMod;

		// Token: 0x04000B91 RID: 2961
		[Token(Token = "0x4000B91")]
		[FieldOffset(Offset = "0x1F6E0")]
		public static readonly AnimationParameter State_PlayerACraftShotgunPumpActionShotgunRail;

		// Token: 0x04000B92 RID: 2962
		[Token(Token = "0x4000B92")]
		[FieldOffset(Offset = "0x1F710")]
		public static readonly AnimationParameter State_PlayerACraftTechArmor;

		// Token: 0x04000B93 RID: 2963
		[Token(Token = "0x4000B93")]
		[FieldOffset(Offset = "0x1F740")]
		public static readonly AnimationParameter State_PlayerACraftTimeBomb;

		// Token: 0x04000B94 RID: 2964
		[Token(Token = "0x4000B94")]
		[FieldOffset(Offset = "0x1F770")]
		public static readonly AnimationParameter State_PlayerACraftZiplineRope;

		// Token: 0x04000B95 RID: 2965
		[Token(Token = "0x4000B95")]
		[FieldOffset(Offset = "0x1F7A0")]
		public static readonly AnimationParameter State_PlayerACrossbowAimFireDown;

		// Token: 0x04000B96 RID: 2966
		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x1F7D0")]
		public static readonly AnimationParameter State_PlayerACrossbowAimFireUp;

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x1F800")]
		public static readonly AnimationParameter State_PlayerACrossbowAimIdleDown;

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x1F830")]
		public static readonly AnimationParameter State_PlayerACrossbowAimIdleDownMP;

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x1F860")]
		public static readonly AnimationParameter State_PlayerACrossbowAimIdleMP;

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4000B9A")]
		[FieldOffset(Offset = "0x1F890")]
		public static readonly AnimationParameter State_PlayerACrossbowAimIdleUp;

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x1F8C0")]
		public static readonly AnimationParameter State_PlayerACrossbowAimIdleUpMP;

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x1F8F0")]
		public static readonly AnimationParameter State_PlayerACrossbowFire_Up;

		// Token: 0x04000B9D RID: 2973
		[Token(Token = "0x4000B9D")]
		[FieldOffset(Offset = "0x1F920")]
		public static readonly AnimationParameter State_PlayerACrossbowFireDown;

		// Token: 0x04000B9E RID: 2974
		[Token(Token = "0x4000B9E")]
		[FieldOffset(Offset = "0x1F950")]
		public static readonly AnimationParameter State_PlayerACrossbowFireDownMP;

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x1F980")]
		public static readonly AnimationParameter State_PlayerACrossbowFireMP;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x1F9B0")]
		public static readonly AnimationParameter State_PlayerACrossbowFireUpMP;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x1F9E0")]
		public static readonly AnimationParameter State_PlayerACrossbowIdleDownMP;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x1FA10")]
		public static readonly AnimationParameter State_PlayerACrossbowIdleMP;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x1FA40")]
		public static readonly AnimationParameter State_PlayerACrossbowIdleUpMP;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x1FA70")]
		public static readonly AnimationParameter State_PlayerADrawSlingshot;

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x1FAA0")]
		public static readonly AnimationParameter State_PlayerADrawSlingshotIdle;

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x1FAD0")]
		public static readonly AnimationParameter State_PlayerAEquipClothingA;

		// Token: 0x04000BA7 RID: 2983
		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x1FB00")]
		public static readonly AnimationParameter State_PlayerAEquipClothingB;

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x1FB30")]
		public static readonly AnimationParameter State_PlayerAEquipClothingC;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x1FB60")]
		public static readonly AnimationParameter State_PlayerAEquipClothingLower;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x1FB90")]
		public static readonly AnimationParameter State_PlayerAEquipClothingUpperA;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x1FBC0")]
		public static readonly AnimationParameter State_PlayerAEquipClothingUpperB;

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x1FBF0")]
		public static readonly AnimationParameter State_PlayerAFreeFormRig;

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x1FC20")]
		public static readonly AnimationParameter State_PlayerAGrenadeHeldToOneHandedPrimed;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0x1FC50")]
		public static readonly AnimationParameter State_PlayerAGrenadeHeldToPrimedA;

		// Token: 0x04000BAF RID: 2991
		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0x1FC80")]
		public static readonly AnimationParameter State_PlayerAGrenadeHeldToPrimedB;

		// Token: 0x04000BB0 RID: 2992
		[Token(Token = "0x4000BB0")]
		[FieldOffset(Offset = "0x1FCB0")]
		public static readonly AnimationParameter State_PlayerAGrenadePrimedAToIdle;

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x1FCE0")]
		public static readonly AnimationParameter State_PlayerAGuitarPlayToIdle;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x1FD10")]
		public static readonly AnimationParameter State_PlayerAHoloCardFirstLook;

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x1FD40")]
		public static readonly AnimationParameter State_PlayerAHoloCardIdle;

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x1FD70")]
		public static readonly AnimationParameter State_PlayerAIdleToSlingshotIdle;

		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x1FDA0")]
		public static readonly AnimationParameter State_PlayerAIdleToSlingshotIdle_0;

		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		[FieldOffset(Offset = "0x1FDD0")]
		public static readonly AnimationParameter State_PlayerAIdleToTimeBombIdle;

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0x1FE00")]
		public static readonly AnimationParameter State_PlayerAIdleToTimeBombIdle_0;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x1FE30")]
		public static readonly AnimationParameter State_PlayerAInventoryIdleToWardrobeIdle;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x1FE60")]
		public static readonly AnimationParameter State_PlayerAInventoryUnwrap;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x1FE90")]
		public static readonly AnimationParameter State_PlayerAKneelToLightFirePrompt;

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		[FieldOffset(Offset = "0x1FEC0")]
		public static readonly AnimationParameter State_PlayerALighterLookAt;

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x1FEF0")]
		public static readonly AnimationParameter State_PlayerALightFire;

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x1FF20")]
		public static readonly AnimationParameter State_PlayerALightFirePrompt;

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x1FF50")]
		public static readonly AnimationParameter State_PlayerALightFirePromptExit;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x1FF80")]
		public static readonly AnimationParameter State_PlayerALightFireStanding;

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		[FieldOffset(Offset = "0x1FFB0")]
		public static readonly AnimationParameter State_PlayerALogLiftAndChop;

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		[FieldOffset(Offset = "0x1FFE0")]
		public static readonly AnimationParameter State_PlayerAnim_PistolAimIdle;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		[FieldOffset(Offset = "0x20010")]
		public static readonly AnimationParameter State_PlayerAnim_PistolAimToIdle;

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[FieldOffset(Offset = "0x20040")]
		public static readonly AnimationParameter State_PlayerAnim_PistolDryFire;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x20070")]
		public static readonly AnimationParameter State_PlayerAnim_PistolEmptyIdle;

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x200A0")]
		public static readonly AnimationParameter State_PlayerAnim_PistolEmptyToReload;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x200D0")]
		public static readonly AnimationParameter State_PlayerAnim_PistolFireA;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x20100")]
		public static readonly AnimationParameter State_PlayerAnim_PistolFireB;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x20130")]
		public static readonly AnimationParameter State_PlayerAnim_PistolFireC;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x20160")]
		public static readonly AnimationParameter State_PlayerAnim_PistolFireD;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x20190")]
		public static readonly AnimationParameter State_PlayerAnim_PistolFireLast;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x201C0")]
		public static readonly AnimationParameter State_PlayerAnim_PistolFirstTimeEquip;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x201F0")]
		public static readonly AnimationParameter State_PlayerAnim_PistolGearUpEquip;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x20220")]
		public static readonly AnimationParameter State_PlayerAnim_PistolHeldToIdle;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x20250")]
		public static readonly AnimationParameter State_PlayerAnim_PistolIdleHeld;

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x20280")]
		public static readonly AnimationParameter State_PlayerAnim_PistolIdleToAim;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x202B0")]
		public static readonly AnimationParameter State_PlayerAnim_PistolIdleToHeld;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x202E0")]
		public static readonly AnimationParameter State_PlayerAnim_PistolReload;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x20310")]
		public static readonly AnimationParameter State_PlayerANovelFirstLook;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x20340")]
		public static readonly AnimationParameter State_PlayerANovelIdle;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x20370")]
		public static readonly AnimationParameter State_PlayerAPistolAimFire;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x203A0")]
		public static readonly AnimationParameter State_PlayerAPistolAimFireB;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x203D0")]
		public static readonly AnimationParameter State_PlayerAPistolAimFireC;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x20400")]
		public static readonly AnimationParameter State_PlayerAPistolAimFireD;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		[FieldOffset(Offset = "0x20430")]
		public static readonly AnimationParameter State_PlayerAPlaceTarpPrompt;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x20460")]
		public static readonly AnimationParameter State_PlayerAPlaceTarpToss;

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0x20490")]
		public static readonly AnimationParameter State_PlayerAPutOnRebreather;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0x204C0")]
		public static readonly AnimationParameter State_PlayerARebreatherLower;

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x204F0")]
		public static readonly AnimationParameter State_PlayerARebreatherRaise;

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x20520")]
		public static readonly AnimationParameter State_PlayerAReleaseSlingshot;

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x20550")]
		public static readonly AnimationParameter State_PlayerAReleaseSlingshot_0;

		// Token: 0x04000BDF RID: 3039
		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x20580")]
		public static readonly AnimationParameter State_PlayerAReloadBow;

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0x205B0")]
		public static readonly AnimationParameter State_PlayerAReloadSlingshot;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0x205E0")]
		public static readonly AnimationParameter State_PlayerAReloadTacticalBow;

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x20610")]
		public static readonly AnimationParameter State_PlayerARifleIdleAimCrouch;

		// Token: 0x04000BE3 RID: 3043
		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x20640")]
		public static readonly AnimationParameter State_PlayerASeveredHeadIdle;

		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x20670")]
		public static readonly AnimationParameter State_PlayerASeveredHeadOnStick;

		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x206A0")]
		public static readonly AnimationParameter State_PlayerAShotgunAimDownSpineFire;

		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x206D0")]
		public static readonly AnimationParameter State_PlayerAShotgunAimDownSpineIdle;

		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x20700")]
		public static readonly AnimationParameter State_PlayerAShotgunFire;

		// Token: 0x04000BE8 RID: 3048
		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0x20730")]
		public static readonly AnimationParameter State_PlayerAShotgunFirstGet;

		// Token: 0x04000BE9 RID: 3049
		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0x20760")]
		public static readonly AnimationParameter State_PlayerAShotgunIdleToReload;

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x20790")]
		public static readonly AnimationParameter State_PlayerAShotgunReload;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x207C0")]
		public static readonly AnimationParameter State_PlayerAShotgunReloadToIdle;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x207F0")]
		public static readonly AnimationParameter State_PlayerAShotgunToAimDownSpine;

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x20820")]
		public static readonly AnimationParameter State_PlayerASlingshotIdle;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x20850")]
		public static readonly AnimationParameter State_PlayerASlingshotIdleEmpty;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x20880")]
		public static readonly AnimationParameter State_PlayerASlingshotIdleEmptyReload;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x208B0")]
		public static readonly AnimationParameter State_PlayerASmallRockHeldIdle;

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x208E0")]
		public static readonly AnimationParameter State_PlayerASmallRockIdleToHeld;

		// Token: 0x04000BF2 RID: 3058
		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x20910")]
		public static readonly AnimationParameter State_PlayerASmallRockIdleToHeldIdle_0;

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x20940")]
		public static readonly AnimationParameter State_PlayerASmallRockThrow;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x20970")]
		public static readonly AnimationParameter State_PlayerAStickLift;

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x209A0")]
		public static readonly AnimationParameter State_PlayerAStickPlaceHorizontal;

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x209D0")]
		public static readonly AnimationParameter State_PlayerAStickPlaceHorizontalPrompt;

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x20A00")]
		public static readonly AnimationParameter State_PlayerAThrowLeaves;

		// Token: 0x04000BF8 RID: 3064
		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x20A30")]
		public static readonly AnimationParameter State_PlayerAThrowLeavesIdle;

		// Token: 0x04000BF9 RID: 3065
		[Token(Token = "0x4000BF9")]
		[FieldOffset(Offset = "0x20A60")]
		public static readonly AnimationParameter State_PlayerAWardrobeIdle;

		// Token: 0x04000BFA RID: 3066
		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x20A90")]
		public static readonly AnimationParameter State_PlayerAWardrobeIdleToInventoryIdle;

		// Token: 0x04000BFB RID: 3067
		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x20AC0")]
		public static readonly AnimationParameter State_PlayerAWardrobeInteract;

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x20AF0")]
		public static readonly AnimationParameter State_playerCrashCycle;

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x20B20")]
		public static readonly AnimationParameter State_PlayerGolfCartDriverEnter;

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x20B50")]
		public static readonly AnimationParameter State_PlayerGolfCartDriverExit;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x20B80")]
		public static readonly AnimationParameter State_PlayerGolfCartDriverIdle;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x20BB0")]
		public static readonly AnimationParameter State_PlayerGolfCartPassengerAEnter;

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x20BE0")]
		public static readonly AnimationParameter State_PlayerGolfCartPassengerAExit;

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x20C10")]
		public static readonly AnimationParameter State_PlayerGolfCartPassengerAIdle;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x20C40")]
		public static readonly AnimationParameter State_playerOnGroundCycle;

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x20C70")]
		public static readonly AnimationParameter State_playerReactToExplosion;

		// Token: 0x04000C05 RID: 3077
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x20CA0")]
		public static readonly AnimationParameter State_playerReactToHitGround;

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x20CD0")]
		public static readonly AnimationParameter State_PlayerShotgunRailAssemble;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x20D00")]
		public static readonly AnimationParameter State_playerThrownForward;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x20D30")]
		public static readonly AnimationParameter State_playerUnwrapTarp;

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x20D60")]
		public static readonly AnimationParameter State_PlectonemeTwister;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x20D90")]
		public static readonly AnimationParameter State_PointAtEnemies;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x20DC0")]
		public static readonly AnimationParameter State_PointAtEnemiesEnd;

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x20DF0")]
		public static readonly AnimationParameter State_PointAtEnemiesStart;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x20E20")]
		public static readonly AnimationParameter State_PointIntro;

		// Token: 0x04000C0E RID: 3086
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x20E50")]
		public static readonly AnimationParameter State_PointLoop;

		// Token: 0x04000C0F RID: 3087
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x20E80")]
		public static readonly AnimationParameter State_pointMap;

		// Token: 0x04000C10 RID: 3088
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x20EB0")]
		public static readonly AnimationParameter State_PointOutro;

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x20EE0")]
		public static readonly AnimationParameter State_PointStanding;

		// Token: 0x04000C12 RID: 3090
		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0x20F10")]
		public static readonly AnimationParameter State_PopDanceA;

		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0x20F40")]
		public static readonly AnimationParameter State_PopDanceB;

		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0x20F70")]
		public static readonly AnimationParameter State_PopDanceC;

		// Token: 0x04000C15 RID: 3093
		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0x20FA0")]
		public static readonly AnimationParameter State_PopDanceD;

		// Token: 0x04000C16 RID: 3094
		[Token(Token = "0x4000C16")]
		[FieldOffset(Offset = "0x20FD0")]
		public static readonly AnimationParameter State_potEmpty;

		// Token: 0x04000C17 RID: 3095
		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0x21000")]
		public static readonly AnimationParameter State_potHeldIdle;

		// Token: 0x04000C18 RID: 3096
		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x21030")]
		public static readonly AnimationParameter State_PotIdle;

		// Token: 0x04000C19 RID: 3097
		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x21060")]
		public static readonly AnimationParameter State_PrayA;

		// Token: 0x04000C1A RID: 3098
		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x21090")]
		public static readonly AnimationParameter State_PrayB;

		// Token: 0x04000C1B RID: 3099
		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x210C0")]
		public static readonly AnimationParameter State_PrayToIdleA;

		// Token: 0x04000C1C RID: 3100
		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x210F0")]
		public static readonly AnimationParameter State_PrayToIdleAlertedA;

		// Token: 0x04000C1D RID: 3101
		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x21120")]
		public static readonly AnimationParameter State_PrayToIdleAlertedB;

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x21150")]
		public static readonly AnimationParameter State_PrayToIdleB;

		// Token: 0x04000C1F RID: 3103
		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x21180")]
		public static readonly AnimationParameter State_PredictionHit;

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x211B0")]
		public static readonly AnimationParameter State_preRoll;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x211E0")]
		public static readonly AnimationParameter State_Pressed;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x21210")]
		public static readonly AnimationParameter State_Pressed_to_Normal;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x21240")]
		public static readonly AnimationParameter State_PrintedFlaskEmpty;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x21270")]
		public static readonly AnimationParameter State_PrintedFlaskEquip;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x212A0")]
		public static readonly AnimationParameter State_PrintedFlaskEqup;

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x212D0")]
		public static readonly AnimationParameter State_PrintedFlaskIdle;

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0x21300")]
		public static readonly AnimationParameter State_PrintedFlaskIdleLowered;

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x21330")]
		public static readonly AnimationParameter State_ProjectileDeathFromGround;

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x21360")]
		public static readonly AnimationParameter State_ProjectileDeathFromGroundStomach;

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x21390")]
		public static readonly AnimationParameter State_ProjectileHitLeftA;

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0x213C0")]
		public static readonly AnimationParameter State_ProjectileHitLeftB;

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x213F0")]
		public static readonly AnimationParameter State_ProjectileHitLeftC;

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0x21420")]
		public static readonly AnimationParameter State_ProjectileHitLeftD;

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x21450")]
		public static readonly AnimationParameter State_ProjectileHitLeftE;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x21480")]
		public static readonly AnimationParameter State_ProjectileHitLeftF;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x214B0")]
		public static readonly AnimationParameter State_ProjectileHitLeftG;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x214E0")]
		public static readonly AnimationParameter State_ProjectileHitLeftH;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x21510")]
		public static readonly AnimationParameter State_ProjectileHitRightA;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x21540")]
		public static readonly AnimationParameter State_ProjectileHitRightB;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x21570")]
		public static readonly AnimationParameter State_ProjectileHitRightC;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x215A0")]
		public static readonly AnimationParameter State_ProjectileHitRightD;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x215D0")]
		public static readonly AnimationParameter State_ProjectileHitRightE;

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x21600")]
		public static readonly AnimationParameter State_ProjectileHitRightF;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x21630")]
		public static readonly AnimationParameter State_ProjectileHitRightG;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x21660")]
		public static readonly AnimationParameter State_ProjectileHitRightH;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x21690")]
		public static readonly AnimationParameter State_ProjectileHitRightI;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x216C0")]
		public static readonly AnimationParameter State_ProjectileHitRightJ;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x216F0")]
		public static readonly AnimationParameter State_ProneBackDeath;

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x21720")]
		public static readonly AnimationParameter State_ProneStomachDeath;

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x21750")]
		public static readonly AnimationParameter State_PufftonBossIntro;

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x21780")]
		public static readonly AnimationParameter State_PuffyDrink;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0x217B0")]
		public static readonly AnimationParameter State_PuffyDrinkOrEatToIdle;

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x217E0")]
		public static readonly AnimationParameter State_PuffyEat;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x21810")]
		public static readonly AnimationParameter State_PuffyIdleToDrink;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x21840")]
		public static readonly AnimationParameter State_PuffyIdleToEat;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x21870")]
		public static readonly AnimationParameter State_pullCraneLoop;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x218A0")]
		public static readonly AnimationParameter State_PushBone;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x218D0")]
		public static readonly AnimationParameter State_PushBonePrompt;

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x21900")]
		public static readonly AnimationParameter State_PushDoor;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x21930")]
		public static readonly AnimationParameter State_PushKick;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x21960")]
		public static readonly AnimationParameter State_pushSledIdle;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x21990")]
		public static readonly AnimationParameter State_PutDown;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x219C0")]
		public static readonly AnimationParameter State_putDownGirl;

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x219F0")]
		public static readonly AnimationParameter State_putTimmyOnMachine;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x21A20")]
		public static readonly AnimationParameter State_RabbitDeath;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x21A50")]
		public static readonly AnimationParameter State_RabbitDrink;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x21A80")]
		public static readonly AnimationParameter State_RabbitEat;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x21AB0")]
		public static readonly AnimationParameter State_RabbitHopFast;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x21AE0")]
		public static readonly AnimationParameter State_RabbitHopSlow;

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x21B10")]
		public static readonly AnimationParameter State_RabbitIdleA;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x21B40")]
		public static readonly AnimationParameter State_RabbitIdleB;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x21B70")]
		public static readonly AnimationParameter State_RabbitRunBinky;

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x21BA0")]
		public static readonly AnimationParameter State_RabbitSleep;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x21BD0")]
		public static readonly AnimationParameter State_RadioEquip;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x21C00")]
		public static readonly AnimationParameter State_RadioIdle;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x21C30")]
		public static readonly AnimationParameter State_RadioUnequip;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x21C60")]
		public static readonly AnimationParameter State_RaftClimbingIn;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x21C90")]
		public static readonly AnimationParameter State_raftIdle;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x21CC0")]
		public static readonly AnimationParameter State_raftPaddleLoop;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x21CF0")]
		public static readonly AnimationParameter State_ReactionIdleToWalkBack;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x21D20")]
		public static readonly AnimationParameter State_ReactionWalkBack;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x21D50")]
		public static readonly AnimationParameter State_ReactionWalkBackToIdle;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x21D80")]
		public static readonly AnimationParameter State_ReboundFromWall;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x21DB0")]
		public static readonly AnimationParameter State_RebreatherIdle;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x21DE0")]
		public static readonly AnimationParameter State_RecoverElectrocuted;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x21E10")]
		public static readonly AnimationParameter State_RecoverElectrocuted2;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x21E40")]
		public static readonly AnimationParameter State_RedWrapLeftUnroll;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x21E70")]
		public static readonly AnimationParameter State_RedWrapLeftUnroll_0;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x21EA0")]
		public static readonly AnimationParameter State_RedWrapOpenIdle;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x21ED0")]
		public static readonly AnimationParameter State_RedWrapTopUnroll;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x21F00")]
		public static readonly AnimationParameter State_RedWrapTopUnroll_0;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x21F30")]
		public static readonly AnimationParameter State_RefillWaterContainer;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x21F60")]
		public static readonly AnimationParameter State_RefuseOrder;

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x21F90")]
		public static readonly AnimationParameter State_Relaxing;

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x21FC0")]
		public static readonly AnimationParameter State_release;

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0x21FF0")]
		public static readonly AnimationParameter State_releaseBow;

		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		[FieldOffset(Offset = "0x22020")]
		public static readonly AnimationParameter State_releaseBow_0;

		// Token: 0x04000C6E RID: 3182
		[Token(Token = "0x4000C6E")]
		[FieldOffset(Offset = "0x22050")]
		public static readonly AnimationParameter State_releaseBowStart;

		// Token: 0x04000C6F RID: 3183
		[Token(Token = "0x4000C6F")]
		[FieldOffset(Offset = "0x22080")]
		public static readonly AnimationParameter State_releaseTacticalBow;

		// Token: 0x04000C70 RID: 3184
		[Token(Token = "0x4000C70")]
		[FieldOffset(Offset = "0x220B0")]
		public static readonly AnimationParameter State_releaseTacticalBow_0;

		// Token: 0x04000C71 RID: 3185
		[Token(Token = "0x4000C71")]
		[FieldOffset(Offset = "0x220E0")]
		public static readonly AnimationParameter State_reloadFlintLock;

		// Token: 0x04000C72 RID: 3186
		[Token(Token = "0x4000C72")]
		[FieldOffset(Offset = "0x22110")]
		public static readonly AnimationParameter State_RepairARepairTool;

		// Token: 0x04000C73 RID: 3187
		[Token(Token = "0x4000C73")]
		[FieldOffset(Offset = "0x22140")]
		public static readonly AnimationParameter State_RepairBRepairTool;

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x22170")]
		public static readonly AnimationParameter State_RepairCRepairTool;

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x221A0")]
		public static readonly AnimationParameter State_repairHammerAttack;

		// Token: 0x04000C76 RID: 3190
		[Token(Token = "0x4000C76")]
		[FieldOffset(Offset = "0x221D0")]
		public static readonly AnimationParameter State_repairHammerAttackToIdle;

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		[FieldOffset(Offset = "0x22200")]
		public static readonly AnimationParameter State_RepairIntroRepairTool;

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		[FieldOffset(Offset = "0x22230")]
		public static readonly AnimationParameter State_RepairOutroRepairTool;

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x22260")]
		public static readonly AnimationParameter State_ResetTrap;

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x22290")]
		public static readonly AnimationParameter State_ResetTrapEnd;

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x222C0")]
		public static readonly AnimationParameter State_Rest;

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x222F0")]
		public static readonly AnimationParameter State_RestToIdle;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x22320")]
		public static readonly AnimationParameter State_RevolverAimFire;

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		[FieldOffset(Offset = "0x22350")]
		public static readonly AnimationParameter State_RevolverAimFireB;

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		[FieldOffset(Offset = "0x22380")]
		public static readonly AnimationParameter State_RevolverAimFireC;

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		[FieldOffset(Offset = "0x223B0")]
		public static readonly AnimationParameter State_RevolverAimFireD;

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		[FieldOffset(Offset = "0x223E0")]
		public static readonly AnimationParameter State_RevolverAimIdle;

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0x22410")]
		public static readonly AnimationParameter State_RevolverAimToIdle;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0x22440")]
		public static readonly AnimationParameter State_RevolverDryFire;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0x22470")]
		public static readonly AnimationParameter State_RevolverEmptyIdle;

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		[FieldOffset(Offset = "0x224A0")]
		public static readonly AnimationParameter State_RevolverEmptyToReload;

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		[FieldOffset(Offset = "0x224D0")]
		public static readonly AnimationParameter State_RevolverFireA;

		// Token: 0x04000C87 RID: 3207
		[Token(Token = "0x4000C87")]
		[FieldOffset(Offset = "0x22500")]
		public static readonly AnimationParameter State_RevolverFireB;

		// Token: 0x04000C88 RID: 3208
		[Token(Token = "0x4000C88")]
		[FieldOffset(Offset = "0x22530")]
		public static readonly AnimationParameter State_RevolverFireC;

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x22560")]
		public static readonly AnimationParameter State_RevolverFireD;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x22590")]
		public static readonly AnimationParameter State_RevolverFireLast;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x225C0")]
		public static readonly AnimationParameter State_RevolverFirstTimeEquip;

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		[FieldOffset(Offset = "0x225F0")]
		public static readonly AnimationParameter State_RevolverHeldToIdle;

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		[FieldOffset(Offset = "0x22620")]
		public static readonly AnimationParameter State_RevolverIdleHeld;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0x22650")]
		public static readonly AnimationParameter State_RevolverIdleToAim;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0x22680")]
		public static readonly AnimationParameter State_RevolverReloadIntro;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0x226B0")]
		public static readonly AnimationParameter State_RevolverReloadLoopA;

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		[FieldOffset(Offset = "0x226E0")]
		public static readonly AnimationParameter State_RevolverReloadLoopB;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0x22710")]
		public static readonly AnimationParameter State_RevolverReloadLoopC;

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0x22740")]
		public static readonly AnimationParameter State_RevolverReloadLoopD;

		// Token: 0x04000C94 RID: 3220
		[Token(Token = "0x4000C94")]
		[FieldOffset(Offset = "0x22770")]
		public static readonly AnimationParameter State_RevolverReloadLoopE;

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x227A0")]
		public static readonly AnimationParameter State_RevolverReloadOutro;

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x227D0")]
		public static readonly AnimationParameter State_RevovlerIdleToHeld;

		// Token: 0x04000C97 RID: 3223
		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x22800")]
		public static readonly AnimationParameter State_RifleAimReload;

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		[FieldOffset(Offset = "0x22830")]
		public static readonly AnimationParameter State_RifleAimToHeld;

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x22860")]
		public static readonly AnimationParameter State_RifleAimToReloadMagazine;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x22890")]
		public static readonly AnimationParameter State_RifleDryFire;

		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4000C9B")]
		[FieldOffset(Offset = "0x228C0")]
		public static readonly AnimationParameter State_RifleFire;

		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x228F0")]
		public static readonly AnimationParameter State_RifleFirstTimeEquip;

		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0x22920")]
		public static readonly AnimationParameter State_RifleGearUpEquip;

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0x22950")]
		public static readonly AnimationParameter State_RifleHeldReload;

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x22980")]
		public static readonly AnimationParameter State_RifleHeldToAim;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x229B0")]
		public static readonly AnimationParameter State_RifleHeldToIdle;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0x229E0")]
		public static readonly AnimationParameter State_RifleIdleAim;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x22A10")]
		public static readonly AnimationParameter State_RifleIdleHeld;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x22A40")]
		public static readonly AnimationParameter State_RifleIdleSpecialReaction;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0x22A70")]
		public static readonly AnimationParameter State_RifleIdleToHeld;

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		[FieldOffset(Offset = "0x22AA0")]
		public static readonly AnimationParameter State_RifleReload;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0x22AD0")]
		public static readonly AnimationParameter State_RifleReloadMagazine;

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		[FieldOffset(Offset = "0x22B00")]
		public static readonly AnimationParameter State_RifleReloadMagazineToAim;

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x22B30")]
		public static readonly AnimationParameter State_Right;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x22B60")]
		public static readonly AnimationParameter State_RobbyCarryArrow;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x22B90")]
		public static readonly AnimationParameter State_RobbyCarryBerries;

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x22BC0")]
		public static readonly AnimationParameter State_RobbyCarryFish;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x22BF0")]
		public static readonly AnimationParameter State_RobbyCarryLog;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x22C20")]
		public static readonly AnimationParameter State_RobbyCarryLogSingle;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x22C50")]
		public static readonly AnimationParameter State_RobbyCarryRock;

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		[FieldOffset(Offset = "0x22C80")]
		public static readonly AnimationParameter State_RobbyCarryStick;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x22CB0")]
		public static readonly AnimationParameter State_RobbyDrink;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x22CE0")]
		public static readonly AnimationParameter State_RobbyDrinkOutro;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x22D10")]
		public static readonly AnimationParameter State_RobbyEatBerries;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x22D40")]
		public static readonly AnimationParameter State_RobbyEatMeat;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x22D70")]
		public static readonly AnimationParameter State_RobbyHelpUp;

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x22DA0")]
		public static readonly AnimationParameter State_RobbyHoldRadio;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x22DD0")]
		public static readonly AnimationParameter State_RobbyPadGiveNote;

		// Token: 0x04000CB7 RID: 3255
		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x22E00")]
		public static readonly AnimationParameter State_RobbyPadGiveOrderFast;

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x22E30")]
		public static readonly AnimationParameter State_RobbyPadLower;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x22E60")]
		public static readonly AnimationParameter State_RobbyPadRaise;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x22E90")]
		public static readonly AnimationParameter State_RobbyPadTakeNote;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x22EC0")]
		public static readonly AnimationParameter State_RobbyPadTakeNoteGame;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x22EF0")]
		public static readonly AnimationParameter State_RobbyPadTakeOrderFast;

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x22F20")]
		public static readonly AnimationParameter State_RobbyPushDoor;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x22F50")]
		public static readonly AnimationParameter State_robeAnim;

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x22F80")]
		public static readonly AnimationParameter State_rockAttack1;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x22FB0")]
		public static readonly AnimationParameter State_rockAttackOnGround1;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x22FE0")]
		public static readonly AnimationParameter State_rockAttackOnGround1_0;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x23010")]
		public static readonly AnimationParameter State_rockAttackToLeft;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x23040")]
		public static readonly AnimationParameter State_rockAttackToRight;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x23070")]
		public static readonly AnimationParameter State_RockCraftCraftedAxe;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x230A0")]
		public static readonly AnimationParameter State_Rocker;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x230D0")]
		public static readonly AnimationParameter State_rockIdle;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x23100")]
		public static readonly AnimationParameter State_RockIdle;

		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x23130")]
		public static readonly AnimationParameter State_rockIdleHigh;

		// Token: 0x04000CC9 RID: 3273
		[Token(Token = "0x4000CC9")]
		[FieldOffset(Offset = "0x23160")]
		public static readonly AnimationParameter State_rolledUp;

		// Token: 0x04000CCA RID: 3274
		[Token(Token = "0x4000CCA")]
		[FieldOffset(Offset = "0x23190")]
		public static readonly AnimationParameter State_rollUp;

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x231C0")]
		public static readonly AnimationParameter State_ropClimbidle;

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x231F0")]
		public static readonly AnimationParameter State_RopeCircuitAnimation;

		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		[FieldOffset(Offset = "0x23220")]
		public static readonly AnimationParameter State_RopeCraftBoneArmor;

		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		[FieldOffset(Offset = "0x23250")]
		public static readonly AnimationParameter State_RopeCraftCraftedAxe;

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x23280")]
		public static readonly AnimationParameter State_RopeCraftCraftedBow;

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0x232B0")]
		public static readonly AnimationParameter State_RopeCraftCraftedClub;

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0x232E0")]
		public static readonly AnimationParameter State_RopeCraftZiplineRope;

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0x23310")]
		public static readonly AnimationParameter State_RopeGunAimFire;

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		[FieldOffset(Offset = "0x23340")]
		public static readonly AnimationParameter State_RopeGunAimIdle;

		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		[FieldOffset(Offset = "0x23370")]
		public static readonly AnimationParameter State_RopeGunAimToIdle;

		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000CD5")]
		[FieldOffset(Offset = "0x233A0")]
		public static readonly AnimationParameter State_RopeGunEquip;

		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000CD6")]
		[FieldOffset(Offset = "0x233D0")]
		public static readonly AnimationParameter State_RopeGunFire;

		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000CD7")]
		[FieldOffset(Offset = "0x23400")]
		public static readonly AnimationParameter State_RopeGunFirstGet;

		// Token: 0x04000CD8 RID: 3288
		[Token(Token = "0x4000CD8")]
		[FieldOffset(Offset = "0x23430")]
		public static readonly AnimationParameter State_RopeGunFirstLook;

		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		[FieldOffset(Offset = "0x23460")]
		public static readonly AnimationParameter State_RopeGunIdle;

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x23490")]
		public static readonly AnimationParameter State_RopeGunReload;

		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x234C0")]
		public static readonly AnimationParameter State_RopeGunUnequip;

		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		[FieldOffset(Offset = "0x234F0")]
		public static readonly AnimationParameter State_RopeIdle;

		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		[FieldOffset(Offset = "0x23520")]
		public static readonly AnimationParameter State_RopeStretcher;

		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		[FieldOffset(Offset = "0x23550")]
		public static readonly AnimationParameter State_Run;

		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x23580")]
		public static readonly AnimationParameter State_RunAggressive;

		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x235B0")]
		public static readonly AnimationParameter State_RunAggressiveToIdle;

		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x235E0")]
		public static readonly AnimationParameter State_RunAttackA;

		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x23610")]
		public static readonly AnimationParameter State_RunAttackB;

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x23640")]
		public static readonly AnimationParameter State_RunAttackC;

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x23670")]
		public static readonly AnimationParameter State_RunAttackE;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x236A0")]
		public static readonly AnimationParameter State_RunAttackF;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x236D0")]
		public static readonly AnimationParameter State_RunAttackG;

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x23700")]
		public static readonly AnimationParameter State_runfast;

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x23730")]
		public static readonly AnimationParameter State_runFast1;

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x23760")]
		public static readonly AnimationParameter State_runFastToIdle;

		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		[FieldOffset(Offset = "0x23790")]
		public static readonly AnimationParameter State_RunForward;

		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		[FieldOffset(Offset = "0x237C0")]
		public static readonly AnimationParameter State_RunForwardAggressive;

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0x237F0")]
		public static readonly AnimationParameter State_RunForwardAggressiveToIdle;

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x23820")]
		public static readonly AnimationParameter State_RunForwardToIdle;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x23850")]
		public static readonly AnimationParameter State_RunForwardToTurn180;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x23880")]
		public static readonly AnimationParameter State_RunForwardToTurn180B;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x238B0")]
		public static readonly AnimationParameter State_RunForwardToTurnLeft;

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x238E0")]
		public static readonly AnimationParameter State_RunForwardToTurnLeftB;

		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x23910")]
		public static readonly AnimationParameter State_RunForwardToTurnRight;

		// Token: 0x04000CF3 RID: 3315
		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x23940")]
		public static readonly AnimationParameter State_RunForwardToTurnRightB;

		// Token: 0x04000CF4 RID: 3316
		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x23970")]
		public static readonly AnimationParameter State_RunIntoWallA;

		// Token: 0x04000CF5 RID: 3317
		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x239A0")]
		public static readonly AnimationParameter State_RunIntoWallB;

		// Token: 0x04000CF6 RID: 3318
		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x239D0")]
		public static readonly AnimationParameter State_RunSlipFallForward;

		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x23A00")]
		public static readonly AnimationParameter State_runToAim180;

		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x23A30")]
		public static readonly AnimationParameter State_runToAimForward;

		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x23A60")]
		public static readonly AnimationParameter State_runToAimLeft;

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x23A90")]
		public static readonly AnimationParameter State_runToAimRight;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x23AC0")]
		public static readonly AnimationParameter State_runToAttack1;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x23AF0")]
		public static readonly AnimationParameter State_runToFallDown;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x23B20")]
		public static readonly AnimationParameter State_RunToIdle;

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x23B50")]
		public static readonly AnimationParameter State_RunToTurn180;

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0x23B80")]
		public static readonly AnimationParameter State_RunToTurnAround;

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x23BB0")]
		public static readonly AnimationParameter State_RunToTurnLeft;

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x23BE0")]
		public static readonly AnimationParameter State_RunToTurnRight;

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x23C10")]
		public static readonly AnimationParameter State_SalmonberriesCraftLootPouch;

		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0x23C40")]
		public static readonly AnimationParameter State_SalmonberriesIdle;

		// Token: 0x04000D04 RID: 3332
		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x23C70")]
		public static readonly AnimationParameter State_SalmonSpearDeath;

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x23CA0")]
		public static readonly AnimationParameter State_sapIdle;

		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x23CD0")]
		public static readonly AnimationParameter State_Scared;

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x23D00")]
		public static readonly AnimationParameter State_ScaredStepBackA;

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x23D30")]
		public static readonly AnimationParameter State_ScaredStepBackB;

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x23D60")]
		public static readonly AnimationParameter State_ScaredStepBackLoop;

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x23D90")]
		public static readonly AnimationParameter State_ScopeModCraftCompactPistolScopeMod;

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x23DC0")]
		public static readonly AnimationParameter State_ScopeModCraftCrossbowScope;

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x23DF0")]
		public static readonly AnimationParameter State_ScopeModCraftShotgunPumpActionScopeMod;

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x23E20")]
		public static readonly AnimationParameter State_ScopeModIdle;

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x23E50")]
		public static readonly AnimationParameter State_Scream;

		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		[FieldOffset(Offset = "0x23E80")]
		public static readonly AnimationParameter State_ScreamAtPlayer;

		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x23EB0")]
		public static readonly AnimationParameter State_ScrewHoldOneSide;

		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		[FieldOffset(Offset = "0x23EE0")]
		public static readonly AnimationParameter State_ScrewHoldUnder;

		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x23F10")]
		public static readonly AnimationParameter State_SeagullDeath;

		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x23F40")]
		public static readonly AnimationParameter State_SeagullEat;

		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x23F70")]
		public static readonly AnimationParameter State_SeagullEatAndFly;

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x23FA0")]
		public static readonly AnimationParameter State_SeagullEatOyster;

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0x23FD0")]
		public static readonly AnimationParameter State_SeagullSitInWater;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x24000")]
		public static readonly AnimationParameter State_seatedRockIdle;

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x24030")]
		public static readonly AnimationParameter State_SeeSomething;

		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0x24060")]
		public static readonly AnimationParameter State_Selected;

		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0x24090")]
		public static readonly AnimationParameter State_SetTimeBombTimer;

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x240C0")]
		public static readonly AnimationParameter State_SeveredArmAttackToLeftA;

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x240F0")]
		public static readonly AnimationParameter State_SeveredArmAttackToRightA;

		// Token: 0x04000D1D RID: 3357
		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0x24120")]
		public static readonly AnimationParameter State_SeveredArmEquip;

		// Token: 0x04000D1E RID: 3358
		[Token(Token = "0x4000D1E")]
		[FieldOffset(Offset = "0x24150")]
		public static readonly AnimationParameter State_SeveredArmIdle;

		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x24180")]
		public static readonly AnimationParameter State_SeveredArmIdleToThrowIdle;

		// Token: 0x04000D20 RID: 3360
		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0x241B0")]
		public static readonly AnimationParameter State_SeveredArmThrow;

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x241E0")]
		public static readonly AnimationParameter State_SeveredArmThrowIdle;

		// Token: 0x04000D22 RID: 3362
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x24210")]
		public static readonly AnimationParameter State_SeveredArmThrowIdleToIdle;

		// Token: 0x04000D23 RID: 3363
		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0x24240")]
		public static readonly AnimationParameter State_SeveredArmUnequip;

		// Token: 0x04000D24 RID: 3364
		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0x24270")]
		public static readonly AnimationParameter State_SeveredHeadEqup;

		// Token: 0x04000D25 RID: 3365
		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0x242A0")]
		public static readonly AnimationParameter State_SeveredHeadIdle;

		// Token: 0x04000D26 RID: 3366
		[Token(Token = "0x4000D26")]
		[FieldOffset(Offset = "0x242D0")]
		public static readonly AnimationParameter State_SeveredHeadScare;

		// Token: 0x04000D27 RID: 3367
		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0x24300")]
		public static readonly AnimationParameter State_SeveredLegAttackToLeftA;

		// Token: 0x04000D28 RID: 3368
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x24330")]
		public static readonly AnimationParameter State_SeveredLegAttackToRightA;

		// Token: 0x04000D29 RID: 3369
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x24360")]
		public static readonly AnimationParameter State_SeveredLegEquip;

		// Token: 0x04000D2A RID: 3370
		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x24390")]
		public static readonly AnimationParameter State_SeveredLegIdle;

		// Token: 0x04000D2B RID: 3371
		[Token(Token = "0x4000D2B")]
		[FieldOffset(Offset = "0x243C0")]
		public static readonly AnimationParameter State_SeveredLegIdleToThrowIdle;

		// Token: 0x04000D2C RID: 3372
		[Token(Token = "0x4000D2C")]
		[FieldOffset(Offset = "0x243F0")]
		public static readonly AnimationParameter State_SeveredLegThrow;

		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x24420")]
		public static readonly AnimationParameter State_SeveredLegThrowIdle;

		// Token: 0x04000D2E RID: 3374
		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x24450")]
		public static readonly AnimationParameter State_SeveredLegThrowIdleToIdle;

		// Token: 0x04000D2F RID: 3375
		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x24480")]
		public static readonly AnimationParameter State_SeveredLegUnequip;

		// Token: 0x04000D30 RID: 3376
		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0x244B0")]
		public static readonly AnimationParameter State_SFM_Arrow;

		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x244E0")]
		public static readonly AnimationParameter State_SFM_In;

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x24510")]
		public static readonly AnimationParameter State_SFM_Out;

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x24540")]
		public static readonly AnimationParameter State_shake1;

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x24570")]
		public static readonly AnimationParameter State_ShakeHead;

		// Token: 0x04000D35 RID: 3381
		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x245A0")]
		public static readonly AnimationParameter State_ShakeHeadStepBack;

		// Token: 0x04000D36 RID: 3382
		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x245D0")]
		public static readonly AnimationParameter State_shellAttack;

		// Token: 0x04000D37 RID: 3383
		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x24600")]
		public static readonly AnimationParameter State_shellBlockLoop;

		// Token: 0x04000D38 RID: 3384
		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x24630")]
		public static readonly AnimationParameter State_shellHeldIdle;

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x24660")]
		public static readonly AnimationParameter State_shellRideIdle;

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x24690")]
		public static readonly AnimationParameter State_shellRideToIdle;

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x246C0")]
		public static readonly AnimationParameter State_Ship;

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x246F0")]
		public static readonly AnimationParameter State_ShiverFromCold;

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x24720")]
		public static readonly AnimationParameter State_shootFlareGun;

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x24750")]
		public static readonly AnimationParameter State_shootFlintLock;

		// Token: 0x04000D3F RID: 3391
		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x24780")]
		public static readonly AnimationParameter State_ShootingKneeling;

		// Token: 0x04000D40 RID: 3392
		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x247B0")]
		public static readonly AnimationParameter State_ShootingKneeling_0;

		// Token: 0x04000D41 RID: 3393
		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x247E0")]
		public static readonly AnimationParameter State_ShootingKneelingReload;

		// Token: 0x04000D42 RID: 3394
		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x24810")]
		public static readonly AnimationParameter State_ShootingKneelingReload_0;

		// Token: 0x04000D43 RID: 3395
		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x24840")]
		public static readonly AnimationParameter State_ShootingLoop;

		// Token: 0x04000D44 RID: 3396
		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x24870")]
		public static readonly AnimationParameter State_ShootingStanding;

		// Token: 0x04000D45 RID: 3397
		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x248A0")]
		public static readonly AnimationParameter State_ShootingStanding_0;

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x248D0")]
		public static readonly AnimationParameter State_ShootingStandingReload;

		// Token: 0x04000D47 RID: 3399
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x24900")]
		public static readonly AnimationParameter State_ShootingStandingReload_0;

		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x24930")]
		public static readonly AnimationParameter State_ShootingStandingToWounded;

		// Token: 0x04000D49 RID: 3401
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x24960")]
		public static readonly AnimationParameter State_ShotBackFallForward;

		// Token: 0x04000D4A RID: 3402
		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x24990")]
		public static readonly AnimationParameter State_shotgunAimDown;

		// Token: 0x04000D4B RID: 3403
		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x249C0")]
		public static readonly AnimationParameter State_shotgunAimDownFire;

		// Token: 0x04000D4C RID: 3404
		[Token(Token = "0x4000D4C")]
		[FieldOffset(Offset = "0x249F0")]
		public static readonly AnimationParameter State_shotgunAimFire;

		// Token: 0x04000D4D RID: 3405
		[Token(Token = "0x4000D4D")]
		[FieldOffset(Offset = "0x24A20")]
		public static readonly AnimationParameter State_shotgunAimFire_0;

		// Token: 0x04000D4E RID: 3406
		[Token(Token = "0x4000D4E")]
		[FieldOffset(Offset = "0x24A50")]
		public static readonly AnimationParameter State_shotgunAimIdle;

		// Token: 0x04000D4F RID: 3407
		[Token(Token = "0x4000D4F")]
		[FieldOffset(Offset = "0x24A80")]
		public static readonly AnimationParameter State_shotgunAimIdle_0;

		// Token: 0x04000D50 RID: 3408
		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x24AB0")]
		public static readonly AnimationParameter State_ShotgunCockGun;

		// Token: 0x04000D51 RID: 3409
		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x24AE0")]
		public static readonly AnimationParameter State_ShotgunCockGunCool;

		// Token: 0x04000D52 RID: 3410
		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x24B10")]
		public static readonly AnimationParameter State_shotgunDownReload;

		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x24B40")]
		public static readonly AnimationParameter State_ShotgunEquip;

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x24B70")]
		public static readonly AnimationParameter State_ShotgunFire;

		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x24BA0")]
		public static readonly AnimationParameter State_shotgunFire;

		// Token: 0x04000D56 RID: 3414
		[Token(Token = "0x4000D56")]
		[FieldOffset(Offset = "0x24BD0")]
		public static readonly AnimationParameter State_shotgunFire_0;

		// Token: 0x04000D57 RID: 3415
		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x24C00")]
		public static readonly AnimationParameter State_shotgunFireCool;

		// Token: 0x04000D58 RID: 3416
		[Token(Token = "0x4000D58")]
		[FieldOffset(Offset = "0x24C30")]
		public static readonly AnimationParameter State_ShotgunHeldToReload;

		// Token: 0x04000D59 RID: 3417
		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x24C60")]
		public static readonly AnimationParameter State_ShotgunIdle;

		// Token: 0x04000D5A RID: 3418
		[Token(Token = "0x4000D5A")]
		[FieldOffset(Offset = "0x24C90")]
		public static readonly AnimationParameter State_shotgunIdle;

		// Token: 0x04000D5B RID: 3419
		[Token(Token = "0x4000D5B")]
		[FieldOffset(Offset = "0x24CC0")]
		public static readonly AnimationParameter State_shotgunIdle_0;

		// Token: 0x04000D5C RID: 3420
		[Token(Token = "0x4000D5C")]
		[FieldOffset(Offset = "0x24CF0")]
		public static readonly AnimationParameter State_ShotgunIdleAim;

		// Token: 0x04000D5D RID: 3421
		[Token(Token = "0x4000D5D")]
		[FieldOffset(Offset = "0x24D20")]
		public static readonly AnimationParameter State_shotgunIdleDown;

		// Token: 0x04000D5E RID: 3422
		[Token(Token = "0x4000D5E")]
		[FieldOffset(Offset = "0x24D50")]
		public static readonly AnimationParameter State_ShotgunIdleHeld;

		// Token: 0x04000D5F RID: 3423
		[Token(Token = "0x4000D5F")]
		[FieldOffset(Offset = "0x24D80")]
		public static readonly AnimationParameter State_shotgunIdleUp;

		// Token: 0x04000D60 RID: 3424
		[Token(Token = "0x4000D60")]
		[FieldOffset(Offset = "0x24DB0")]
		public static readonly AnimationParameter State_ShotgunPumpActionCraftShotgunPumpActionFlashlightMod;

		// Token: 0x04000D61 RID: 3425
		[Token(Token = "0x4000D61")]
		[FieldOffset(Offset = "0x24DE0")]
		public static readonly AnimationParameter State_ShotgunPumpActionCraftShotgunPumpActionLaserSightMod;

		// Token: 0x04000D62 RID: 3426
		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x24E10")]
		public static readonly AnimationParameter State_ShotgunPumpActionCraftShotgunPumpActionScopeMod;

		// Token: 0x04000D63 RID: 3427
		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0x24E40")]
		public static readonly AnimationParameter State_ShotgunPumpActionCraftShotgunPumpActionShotgunRail;

		// Token: 0x04000D64 RID: 3428
		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x24E70")]
		public static readonly AnimationParameter State_ShotgunPumpActionIdle;

		// Token: 0x04000D65 RID: 3429
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x24EA0")]
		public static readonly AnimationParameter State_ShotgunRailAssemble;

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x24ED0")]
		public static readonly AnimationParameter State_ShotgunRailCraftShotgunPumpActionShotgunRail;

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0x24F00")]
		public static readonly AnimationParameter State_ShotgunRailIdle;

		// Token: 0x04000D68 RID: 3432
		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0x24F30")]
		public static readonly AnimationParameter State_shotgunReload;

		// Token: 0x04000D69 RID: 3433
		[Token(Token = "0x4000D69")]
		[FieldOffset(Offset = "0x24F60")]
		public static readonly AnimationParameter State_ShotgunReload;

		// Token: 0x04000D6A RID: 3434
		[Token(Token = "0x4000D6A")]
		[FieldOffset(Offset = "0x24F90")]
		public static readonly AnimationParameter State_shotgunReload_0;

		// Token: 0x04000D6B RID: 3435
		[Token(Token = "0x4000D6B")]
		[FieldOffset(Offset = "0x24FC0")]
		public static readonly AnimationParameter State_shotgunReloadCool;

		// Token: 0x04000D6C RID: 3436
		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x24FF0")]
		public static readonly AnimationParameter State_ShotgunReloadRightHand;

		// Token: 0x04000D6D RID: 3437
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x25020")]
		public static readonly AnimationParameter State_shotgunReloadRightHand;

		// Token: 0x04000D6E RID: 3438
		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0x25050")]
		public static readonly AnimationParameter State_ShotgunReloadToIdleHeld;

		// Token: 0x04000D6F RID: 3439
		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x25080")]
		public static readonly AnimationParameter State_shotgunReloadUp;

		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x250B0")]
		public static readonly AnimationParameter State_ShotgunUnequip;

		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x250E0")]
		public static readonly AnimationParameter State_ShotHeadFall;

		// Token: 0x04000D72 RID: 3442
		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x25110")]
		public static readonly AnimationParameter State_ShotHeadFallBack;

		// Token: 0x04000D73 RID: 3443
		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x25140")]
		public static readonly AnimationParameter State_ShotHeadFallBackA;

		// Token: 0x04000D74 RID: 3444
		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x25170")]
		public static readonly AnimationParameter State_ShotHeadFallBackB;

		// Token: 0x04000D75 RID: 3445
		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x251A0")]
		public static readonly AnimationParameter State_ShotHeadFallForward;

		// Token: 0x04000D76 RID: 3446
		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x251D0")]
		public static readonly AnimationParameter State_shovelDig;

		// Token: 0x04000D77 RID: 3447
		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x25200")]
		public static readonly AnimationParameter State_shovelDigBlocked;

		// Token: 0x04000D78 RID: 3448
		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x25230")]
		public static readonly AnimationParameter State_shovelDigBlockedA;

		// Token: 0x04000D79 RID: 3449
		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0x25260")]
		public static readonly AnimationParameter State_shovelDigBlockedB;

		// Token: 0x04000D7A RID: 3450
		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x25290")]
		public static readonly AnimationParameter State_shovelDigEmpty;

		// Token: 0x04000D7B RID: 3451
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x252C0")]
		public static readonly AnimationParameter State_ShovelDigInLine;

		// Token: 0x04000D7C RID: 3452
		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x252F0")]
		public static readonly AnimationParameter State_shovelDigLoop;

		// Token: 0x04000D7D RID: 3453
		[Token(Token = "0x4000D7D")]
		[FieldOffset(Offset = "0x25320")]
		public static readonly AnimationParameter State_shovelDigOld;

		// Token: 0x04000D7E RID: 3454
		[Token(Token = "0x4000D7E")]
		[FieldOffset(Offset = "0x25350")]
		public static readonly AnimationParameter State_shovelDigRepeat;

		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0x25380")]
		public static readonly AnimationParameter State_shovelEquip;

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x253B0")]
		public static readonly AnimationParameter State_shovelFill;

		// Token: 0x04000D81 RID: 3457
		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0x253E0")]
		public static readonly AnimationParameter State_shovelIdle;

		// Token: 0x04000D82 RID: 3458
		[Token(Token = "0x4000D82")]
		[FieldOffset(Offset = "0x25410")]
		public static readonly AnimationParameter State_shovelStab;

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x25440")]
		public static readonly AnimationParameter State_shovelUnequip;

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0x25470")]
		public static readonly AnimationParameter State_show;

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x254A0")]
		public static readonly AnimationParameter State_simTest2;

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x254D0")]
		public static readonly AnimationParameter State_SitA;

		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x25500")]
		public static readonly AnimationParameter State_SitB;

		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x25530")]
		public static readonly AnimationParameter State_SitC;

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x25560")]
		public static readonly AnimationParameter State_SitChair;

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0x25590")]
		public static readonly AnimationParameter State_SitChairIdle;

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x255C0")]
		public static readonly AnimationParameter State_SitChairToIdle;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x255F0")]
		public static readonly AnimationParameter State_SitD;

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x25620")]
		public static readonly AnimationParameter State_sitDownIdle;

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x25650")]
		public static readonly AnimationParameter State_SitDownInWaterStart;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x25680")]
		public static readonly AnimationParameter State_sitDownToIdle;

		// Token: 0x04000D90 RID: 3472
		[Token(Token = "0x4000D90")]
		[FieldOffset(Offset = "0x256B0")]
		public static readonly AnimationParameter State_sitIdleToStand;

		// Token: 0x04000D91 RID: 3473
		[Token(Token = "0x4000D91")]
		[FieldOffset(Offset = "0x256E0")]
		public static readonly AnimationParameter State_SitOnGround;

		// Token: 0x04000D92 RID: 3474
		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x25710")]
		public static readonly AnimationParameter State_SitOnGroundIdle;

		// Token: 0x04000D93 RID: 3475
		[Token(Token = "0x4000D93")]
		[FieldOffset(Offset = "0x25740")]
		public static readonly AnimationParameter State_SitRubToes;

		// Token: 0x04000D94 RID: 3476
		[Token(Token = "0x4000D94")]
		[FieldOffset(Offset = "0x25770")]
		public static readonly AnimationParameter State_SitRubToesToIdle;

		// Token: 0x04000D95 RID: 3477
		[Token(Token = "0x4000D95")]
		[FieldOffset(Offset = "0x257A0")]
		public static readonly AnimationParameter State_sittingLoop;

		// Token: 0x04000D96 RID: 3478
		[Token(Token = "0x4000D96")]
		[FieldOffset(Offset = "0x257D0")]
		public static readonly AnimationParameter State_SitToIdleA;

		// Token: 0x04000D97 RID: 3479
		[Token(Token = "0x4000D97")]
		[FieldOffset(Offset = "0x25800")]
		public static readonly AnimationParameter State_SitToIdleAlertedA;

		// Token: 0x04000D98 RID: 3480
		[Token(Token = "0x4000D98")]
		[FieldOffset(Offset = "0x25830")]
		public static readonly AnimationParameter State_SitToIdleAlertedB;

		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		[FieldOffset(Offset = "0x25860")]
		public static readonly AnimationParameter State_SitToIdleAlertedC;

		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x25890")]
		public static readonly AnimationParameter State_SitToIdleAlertedD;

		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x258C0")]
		public static readonly AnimationParameter State_SitToIdleB;

		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x258F0")]
		public static readonly AnimationParameter State_SitToIdleC;

		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0x25920")]
		public static readonly AnimationParameter State_SitToIdleD;

		// Token: 0x04000D9E RID: 3486
		[Token(Token = "0x4000D9E")]
		[FieldOffset(Offset = "0x25950")]
		public static readonly AnimationParameter State_skinAnimal;

		// Token: 0x04000D9F RID: 3487
		[Token(Token = "0x4000D9F")]
		[FieldOffset(Offset = "0x25980")]
		public static readonly AnimationParameter State_SkullCraftCraftedClub;

		// Token: 0x04000DA0 RID: 3488
		[Token(Token = "0x4000DA0")]
		[FieldOffset(Offset = "0x259B0")]
		public static readonly AnimationParameter State_SkullIdle;

		// Token: 0x04000DA1 RID: 3489
		[Token(Token = "0x4000DA1")]
		[FieldOffset(Offset = "0x259E0")]
		public static readonly AnimationParameter State_SlapFightA;

		// Token: 0x04000DA2 RID: 3490
		[Token(Token = "0x4000DA2")]
		[FieldOffset(Offset = "0x25A10")]
		public static readonly AnimationParameter State_SlapFightB;

		// Token: 0x04000DA3 RID: 3491
		[Token(Token = "0x4000DA3")]
		[FieldOffset(Offset = "0x25A40")]
		public static readonly AnimationParameter State_SlapFightKnockout;

		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		[FieldOffset(Offset = "0x25A70")]
		public static readonly AnimationParameter State_SlapFightKnockoutGetUp;

		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		[FieldOffset(Offset = "0x25AA0")]
		public static readonly AnimationParameter State_SlapFightVictory;

		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		[FieldOffset(Offset = "0x25AD0")]
		public static readonly AnimationParameter State_SledEquip;

		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x25B00")]
		public static readonly AnimationParameter State_SledIdle;

		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0x25B30")]
		public static readonly AnimationParameter State_SledIdleBase;

		// Token: 0x04000DA9 RID: 3497
		[Token(Token = "0x4000DA9")]
		[FieldOffset(Offset = "0x25B60")]
		public static readonly AnimationParameter State_SledUnequip;

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x25B90")]
		public static readonly AnimationParameter State_Sleep;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x25BC0")]
		public static readonly AnimationParameter State_SleepB;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x25BF0")]
		public static readonly AnimationParameter State_SleepCrouchedA;

		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		[FieldOffset(Offset = "0x25C20")]
		public static readonly AnimationParameter State_SleepCrouchedAIntro;

		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		[FieldOffset(Offset = "0x25C50")]
		public static readonly AnimationParameter State_SleepCrouchedAOutro;

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x25C80")]
		public static readonly AnimationParameter State_SleepCrouchedB;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x25CB0")]
		public static readonly AnimationParameter State_SleepCrouchedBIntro;

		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0x25CE0")]
		public static readonly AnimationParameter State_SleepCrouchedBOutro;

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x25D10")]
		public static readonly AnimationParameter State_SleepCrouchedC;

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x25D40")]
		public static readonly AnimationParameter State_SleepCrouchedCIntro;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x25D70")]
		public static readonly AnimationParameter State_SleepCrouchedCOutro;

		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x25DA0")]
		public static readonly AnimationParameter State_SleepStandingUp;

		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x25DD0")]
		public static readonly AnimationParameter State_SleepStandingUpIntro;

		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0x25E00")]
		public static readonly AnimationParameter State_SleepStandingUpOutro;

		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x25E30")]
		public static readonly AnimationParameter State_SleepToIdle;

		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x25E60")]
		public static readonly AnimationParameter State_SleepToIdleB;

		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0x25E90")]
		public static readonly AnimationParameter State_SlideDownIntro;

		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000DBB")]
		[FieldOffset(Offset = "0x25EC0")]
		public static readonly AnimationParameter State_SlideDownLoop;

		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0x25EF0")]
		public static readonly AnimationParameter State_SlideDownOutro;

		// Token: 0x04000DBD RID: 3517
		[Token(Token = "0x4000DBD")]
		[FieldOffset(Offset = "0x25F20")]
		public static readonly AnimationParameter State_SlideDownSlopeIntro;

		// Token: 0x04000DBE RID: 3518
		[Token(Token = "0x4000DBE")]
		[FieldOffset(Offset = "0x25F50")]
		public static readonly AnimationParameter State_SlideDownSlopeLoop;

		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0x25F80")]
		public static readonly AnimationParameter State_SlideDownSlopeOutro;

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x25FB0")]
		public static readonly AnimationParameter State_SlideIn;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x25FE0")]
		public static readonly AnimationParameter State_SlideLogIdle;

		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x26010")]
		public static readonly AnimationParameter State_SlideLogIdleLeft;

		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x26040")]
		public static readonly AnimationParameter State_SlideLogIdleRight;

		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0x26070")]
		public static readonly AnimationParameter State_SlideOut;

		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x260A0")]
		public static readonly AnimationParameter State_slingShotAimIdle;

		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x260D0")]
		public static readonly AnimationParameter State_slingShotIdle;

		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000DC7")]
		[FieldOffset(Offset = "0x26100")]
		public static readonly AnimationParameter State_slingShotShoot;

		// Token: 0x04000DC8 RID: 3528
		[Token(Token = "0x4000DC8")]
		[FieldOffset(Offset = "0x26130")]
		public static readonly AnimationParameter State_slowAttack;

		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000DC9")]
		[FieldOffset(Offset = "0x26160")]
		public static readonly AnimationParameter State_slowAttack_0;

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		[FieldOffset(Offset = "0x26190")]
		public static readonly AnimationParameter State_slowAttackToIdle;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		[FieldOffset(Offset = "0x261C0")]
		public static readonly AnimationParameter State_slowAxeAttack;

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		[FieldOffset(Offset = "0x261F0")]
		public static readonly AnimationParameter State_slowAxeAttackRight;

		// Token: 0x04000DCD RID: 3533
		[Token(Token = "0x4000DCD")]
		[FieldOffset(Offset = "0x26220")]
		public static readonly AnimationParameter State_slowAxeAttackRightToIdle;

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		[FieldOffset(Offset = "0x26250")]
		public static readonly AnimationParameter State_slowAxeAttackToIdle;

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000DCF")]
		[FieldOffset(Offset = "0x26280")]
		public static readonly AnimationParameter State_slowAxeSwing;

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000DD0")]
		[FieldOffset(Offset = "0x262B0")]
		public static readonly AnimationParameter State_slowAxeSwing_0;

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000DD1")]
		[FieldOffset(Offset = "0x262E0")]
		public static readonly AnimationParameter State_slowClubAttack;

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000DD2")]
		[FieldOffset(Offset = "0x26310")]
		public static readonly AnimationParameter State_slowClubAttackRight;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0x26340")]
		public static readonly AnimationParameter State_slowClubAttackRightToIdle;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000DD4")]
		[FieldOffset(Offset = "0x26370")]
		public static readonly AnimationParameter State_slowClubAttackToIdle;

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[FieldOffset(Offset = "0x263A0")]
		public static readonly AnimationParameter State_slowSwingToIdle;

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0x263D0")]
		public static readonly AnimationParameter State_SlowTaserStickAttack;

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000DD7")]
		[FieldOffset(Offset = "0x26400")]
		public static readonly AnimationParameter State_SlowTaserStickAttackRightToIdle;

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x26430")]
		public static readonly AnimationParameter State_SlowTaserStickAttackToIdle;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x26460")]
		public static readonly AnimationParameter State_SlowTaserStrickAttackRight;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x26490")]
		public static readonly AnimationParameter State_SlowToHover;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x264C0")]
		public static readonly AnimationParameter State_SlugAmmoCraftLootPouch;

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x264F0")]
		public static readonly AnimationParameter State_SlugAmmoIdle;

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x26520")]
		public static readonly AnimationParameter State_SmallAnimalCatcherResetTrap;

		// Token: 0x04000DDE RID: 3550
		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x26550")]
		public static readonly AnimationParameter State_SmallAnimalCatcherTriggerTrap;

		// Token: 0x04000DDF RID: 3551
		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x26580")]
		public static readonly AnimationParameter State_SmallFlaskEquip;

		// Token: 0x04000DE0 RID: 3552
		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0x265B0")]
		public static readonly AnimationParameter State_SmallFlaskIdle;

		// Token: 0x04000DE1 RID: 3553
		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x265E0")]
		public static readonly AnimationParameter State_SmallFlaskIdleLowered;

		// Token: 0x04000DE2 RID: 3554
		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x26610")]
		public static readonly AnimationParameter State_SmallHitBackA;

		// Token: 0x04000DE3 RID: 3555
		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x26640")]
		public static readonly AnimationParameter State_SmallHitBackB;

		// Token: 0x04000DE4 RID: 3556
		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x26670")]
		public static readonly AnimationParameter State_SmallRockACraftCraftedArrows;

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x266A0")]
		public static readonly AnimationParameter State_SmallRockBCraftCraftedArrows;

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x266D0")]
		public static readonly AnimationParameter State_SmallRockCCraftCraftedArrows;

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x26700")]
		public static readonly AnimationParameter State_SmallRockCraftLootPouch;

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000DE8")]
		[FieldOffset(Offset = "0x26730")]
		public static readonly AnimationParameter State_SmallRockDCraftCraftedArrows;

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000DE9")]
		[FieldOffset(Offset = "0x26760")]
		public static readonly AnimationParameter State_SmallRockIdle;

		// Token: 0x04000DEA RID: 3562
		[Token(Token = "0x4000DEA")]
		[FieldOffset(Offset = "0x26790")]
		public static readonly AnimationParameter State_SnowCrashBadGuyIntro;

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000DEB")]
		[FieldOffset(Offset = "0x267C0")]
		public static readonly AnimationParameter State_SnowCrashHelicopter;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		[FieldOffset(Offset = "0x267F0")]
		public static readonly AnimationParameter State_SnowCrashPilot;

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		[FieldOffset(Offset = "0x26820")]
		public static readonly AnimationParameter State_SnowCrashPlayer;

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		[FieldOffset(Offset = "0x26850")]
		public static readonly AnimationParameter State_SnowCrashStandup;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[FieldOffset(Offset = "0x26880")]
		public static readonly AnimationParameter State_SnowCrashTactiA;

		// Token: 0x04000DF0 RID: 3568
		[Token(Token = "0x4000DF0")]
		[FieldOffset(Offset = "0x268B0")]
		public static readonly AnimationParameter State_SnowCrashTactiB;

		// Token: 0x04000DF1 RID: 3569
		[Token(Token = "0x4000DF1")]
		[FieldOffset(Offset = "0x268E0")]
		public static readonly AnimationParameter State_Soccer_Kick;

		// Token: 0x04000DF2 RID: 3570
		[Token(Token = "0x4000DF2")]
		[FieldOffset(Offset = "0x26910")]
		public static readonly AnimationParameter State_SoccerKick;

		// Token: 0x04000DF3 RID: 3571
		[Token(Token = "0x4000DF3")]
		[FieldOffset(Offset = "0x26940")]
		public static readonly AnimationParameter State_SolarPanelEquip;

		// Token: 0x04000DF4 RID: 3572
		[Token(Token = "0x4000DF4")]
		[FieldOffset(Offset = "0x26970")]
		public static readonly AnimationParameter State_SolarPanelIdle;

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000DF5")]
		[FieldOffset(Offset = "0x269A0")]
		public static readonly AnimationParameter State_SolarPanelUnequip;

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0x269D0")]
		public static readonly AnimationParameter State_SpawnBaby;

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x26A00")]
		public static readonly AnimationParameter State_SpawnIntro;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x26A30")]
		public static readonly AnimationParameter State_SpawnMultiBaby;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x26A60")]
		public static readonly AnimationParameter State_SpawnTwins;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x26A90")]
		public static readonly AnimationParameter State_spearIdle;

		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x26AC0")]
		public static readonly AnimationParameter State_spearIdleHigh;

		// Token: 0x04000DFC RID: 3580
		[Token(Token = "0x4000DFC")]
		[FieldOffset(Offset = "0x26AF0")]
		public static readonly AnimationParameter State_spearIdleHighToThrowIdle;

		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000DFD")]
		[FieldOffset(Offset = "0x26B20")]
		public static readonly AnimationParameter State_spearIdleToSpearIdleHigh;

		// Token: 0x04000DFE RID: 3582
		[Token(Token = "0x4000DFE")]
		[FieldOffset(Offset = "0x26B50")]
		public static readonly AnimationParameter State_spearIdleToSpearIdleHigh_0;

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x26B80")]
		public static readonly AnimationParameter State_spearStab1;

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x26BB0")]
		public static readonly AnimationParameter State_spearStabHigh1;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		[FieldOffset(Offset = "0x26BE0")]
		public static readonly AnimationParameter State_spearThrowIdle;

		// Token: 0x04000E02 RID: 3586
		[Token(Token = "0x4000E02")]
		[FieldOffset(Offset = "0x26C10")]
		public static readonly AnimationParameter State_spearThrowIdleToIdleHigh;

		// Token: 0x04000E03 RID: 3587
		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x26C40")]
		public static readonly AnimationParameter State_SphereGrab;

		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x26C70")]
		public static readonly AnimationParameter State_Spin;

		// Token: 0x04000E05 RID: 3589
		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x26CA0")]
		public static readonly AnimationParameter State_spinePitch;

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x26CD0")]
		public static readonly AnimationParameter State_spinePitch_net;

		// Token: 0x04000E07 RID: 3591
		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x26D00")]
		public static readonly AnimationParameter State_spinePitchArmsKnightV;

		// Token: 0x04000E08 RID: 3592
		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x26D30")]
		public static readonly AnimationParameter State_spinePitchArmsMoveBlend;

		// Token: 0x04000E09 RID: 3593
		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x26D60")]
		public static readonly AnimationParameter State_spinePitchNetworkTestMP;

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x26D90")]
		public static readonly AnimationParameter State_spinePitchTree;

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x26DC0")]
		public static readonly AnimationParameter State_spinePitchTreeClean;

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x26DF0")]
		public static readonly AnimationParameter State_spineRidingPitchTwist;

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x26E20")]
		public static readonly AnimationParameter State_spineTwist;

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x26E50")]
		public static readonly AnimationParameter State_spit;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x26E80")]
		public static readonly AnimationParameter State_SpitA;

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x26EB0")]
		public static readonly AnimationParameter State_SpitB;

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000E11")]
		[FieldOffset(Offset = "0x26EE0")]
		public static readonly AnimationParameter State_SpitC;

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		[FieldOffset(Offset = "0x26F10")]
		public static readonly AnimationParameter State_SpitD;

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000E13")]
		[FieldOffset(Offset = "0x26F40")]
		public static readonly AnimationParameter State_Splash_Disabled;

		// Token: 0x04000E14 RID: 3604
		[Token(Token = "0x4000E14")]
		[FieldOffset(Offset = "0x26F70")]
		public static readonly AnimationParameter State_Splash_In;

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000E15")]
		[FieldOffset(Offset = "0x26FA0")]
		public static readonly AnimationParameter State_Splash_Out;

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000E16")]
		[FieldOffset(Offset = "0x26FD0")]
		public static readonly AnimationParameter State_SpringBase;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x27000")]
		public static readonly AnimationParameter State_SprintForward;

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000E18")]
		[FieldOffset(Offset = "0x27030")]
		public static readonly AnimationParameter State_SprintForwardToIdle;

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		[FieldOffset(Offset = "0x27060")]
		public static readonly AnimationParameter State_SquirrelAlertLeft;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000E1A")]
		[FieldOffset(Offset = "0x27090")]
		public static readonly AnimationParameter State_SquirrelAlertRight;

		// Token: 0x04000E1B RID: 3611
		[Token(Token = "0x4000E1B")]
		[FieldOffset(Offset = "0x270C0")]
		public static readonly AnimationParameter State_SquirrelDeath;

		// Token: 0x04000E1C RID: 3612
		[Token(Token = "0x4000E1C")]
		[FieldOffset(Offset = "0x270F0")]
		public static readonly AnimationParameter State_SquirrelDrink;

		// Token: 0x04000E1D RID: 3613
		[Token(Token = "0x4000E1D")]
		[FieldOffset(Offset = "0x27120")]
		public static readonly AnimationParameter State_SquirrelEat;

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x27150")]
		public static readonly AnimationParameter State_SquirrelHopSlow;

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x27180")]
		public static readonly AnimationParameter State_SquirrelIdleA;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x271B0")]
		public static readonly AnimationParameter State_SquirrelIdleB;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x271E0")]
		public static readonly AnimationParameter State_SquirrelRun;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x27210")]
		public static readonly AnimationParameter State_SquirrelSleep;

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x27240")]
		public static readonly AnimationParameter State_stabWindup;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x27270")]
		public static readonly AnimationParameter State_Stand_Half_Turn_Right;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x272A0")]
		public static readonly AnimationParameter State_StandingToEnterHatch;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x272D0")]
		public static readonly AnimationParameter State_StandToCrouchHiddenA;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x27300")]
		public static readonly AnimationParameter State_StandToCrouchHiddenA180;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x27330")]
		public static readonly AnimationParameter State_standup;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x27360")]
		public static readonly AnimationParameter State_standUpIdle;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x27390")]
		public static readonly AnimationParameter State_standupInjured;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x273C0")]
		public static readonly AnimationParameter State_start;

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x273F0")]
		public static readonly AnimationParameter State_Start;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x27420")]
		public static readonly AnimationParameter State_StartleReaction;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x27450")]
		public static readonly AnimationParameter State_StepBack;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x27480")]
		public static readonly AnimationParameter State_StepBackScared;

		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000E30")]
		[FieldOffset(Offset = "0x274B0")]
		public static readonly AnimationParameter State_StepBackScared01;

		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000E31")]
		[FieldOffset(Offset = "0x274E0")]
		public static readonly AnimationParameter State_StepBackToIdle;

		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x27510")]
		public static readonly AnimationParameter State_StepCurious;

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x27540")]
		public static readonly AnimationParameter State_StepCuriousBack;

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x27570")]
		public static readonly AnimationParameter State_StepCuriousToIdle;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x275A0")]
		public static readonly AnimationParameter State_StepCuriousToIdleBack;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x275D0")]
		public static readonly AnimationParameter State_StickACraftCraftedArrows;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x27600")]
		public static readonly AnimationParameter State_StickACraftCraftedBow;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x27630")]
		public static readonly AnimationParameter State_StickACraftCraftedSpear;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x27660")]
		public static readonly AnimationParameter State_stickAttackCombo1;

		// Token: 0x04000E3A RID: 3642
		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0x27690")]
		public static readonly AnimationParameter State_stickAttackCombo2;

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x276C0")]
		public static readonly AnimationParameter State_StickBCraftCraftedArrows;

		// Token: 0x04000E3C RID: 3644
		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0x276F0")]
		public static readonly AnimationParameter State_StickBCraftCraftedBow;

		// Token: 0x04000E3D RID: 3645
		[Token(Token = "0x4000E3D")]
		[FieldOffset(Offset = "0x27720")]
		public static readonly AnimationParameter State_StickBCraftCraftedSpear;

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000E3E")]
		[FieldOffset(Offset = "0x27750")]
		public static readonly AnimationParameter State_stickBlock1;

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0x27780")]
		public static readonly AnimationParameter State_stickBlock2;

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000E40")]
		[FieldOffset(Offset = "0x277B0")]
		public static readonly AnimationParameter State_stickBlockHit1;

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000E41")]
		[FieldOffset(Offset = "0x277E0")]
		public static readonly AnimationParameter State_stickBlockHit2;

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0x27810")]
		public static readonly AnimationParameter State_stickBlockToIdle;

		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000E43")]
		[FieldOffset(Offset = "0x27840")]
		public static readonly AnimationParameter State_StickBreakAndPlace;

		// Token: 0x04000E44 RID: 3652
		[Token(Token = "0x4000E44")]
		[FieldOffset(Offset = "0x27870")]
		public static readonly AnimationParameter State_StickBreakAndPlacePrompt;

		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000E45")]
		[FieldOffset(Offset = "0x278A0")]
		public static readonly AnimationParameter State_StickBreakAndPlaceToPrompt;

		// Token: 0x04000E46 RID: 3654
		[Token(Token = "0x4000E46")]
		[FieldOffset(Offset = "0x278D0")]
		public static readonly AnimationParameter State_StickCraftCraftedAxe;

		// Token: 0x04000E47 RID: 3655
		[Token(Token = "0x4000E47")]
		[FieldOffset(Offset = "0x27900")]
		public static readonly AnimationParameter State_StickCraftCraftedClub;

		// Token: 0x04000E48 RID: 3656
		[Token(Token = "0x4000E48")]
		[FieldOffset(Offset = "0x27930")]
		public static readonly AnimationParameter State_StickCraftCraftedTorch;

		// Token: 0x04000E49 RID: 3657
		[Token(Token = "0x4000E49")]
		[FieldOffset(Offset = "0x27960")]
		public static readonly AnimationParameter State_StickGrab;

		// Token: 0x04000E4A RID: 3658
		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x27990")]
		public static readonly AnimationParameter State_stickHeavyAttack;

		// Token: 0x04000E4B RID: 3659
		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0x279C0")]
		public static readonly AnimationParameter State_stickHeavyAttackWindup;

		// Token: 0x04000E4C RID: 3660
		[Token(Token = "0x4000E4C")]
		[FieldOffset(Offset = "0x279F0")]
		public static readonly AnimationParameter State_StickIdle;

		// Token: 0x04000E4D RID: 3661
		[Token(Token = "0x4000E4D")]
		[FieldOffset(Offset = "0x27A20")]
		public static readonly AnimationParameter State_stickJab;

		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x27A50")]
		public static readonly AnimationParameter State_stickJabIdle;

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x27A80")]
		public static readonly AnimationParameter State_StickPlantAndTwistToIdle;

		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0x27AB0")]
		public static readonly AnimationParameter State_stickShove;

		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x27AE0")]
		public static readonly AnimationParameter State_StoneEquip;

		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x27B10")]
		public static readonly AnimationParameter State_StoneIdle;

		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		[FieldOffset(Offset = "0x27B40")]
		public static readonly AnimationParameter State_StoneToss;

		// Token: 0x04000E54 RID: 3668
		[Token(Token = "0x4000E54")]
		[FieldOffset(Offset = "0x27B70")]
		public static readonly AnimationParameter State_StoneUnequip;

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x27BA0")]
		public static readonly AnimationParameter State_StorageCrateAOpen;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x27BD0")]
		public static readonly AnimationParameter State_StorageCrateBOpen;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x27C00")]
		public static readonly AnimationParameter State_StrafeIntroTest;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x27C30")]
		public static readonly AnimationParameter State_StrafeOutroTest;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x27C60")]
		public static readonly AnimationParameter State_Strafes;

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		[FieldOffset(Offset = "0x27C90")]
		public static readonly AnimationParameter State_StrafeTest;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		[FieldOffset(Offset = "0x27CC0")]
		public static readonly AnimationParameter State_StrafeToIdle;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x27CF0")]
		public static readonly AnimationParameter State_StrongWind;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x27D20")]
		public static readonly AnimationParameter State_StuckSlugAgitated;

		// Token: 0x04000E5E RID: 3678
		[Token(Token = "0x4000E5E")]
		[FieldOffset(Offset = "0x27D50")]
		public static readonly AnimationParameter State_StuckSlugIdle;

		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0x27D80")]
		public static readonly AnimationParameter State_StunGunDryFire;

		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000E60")]
		[FieldOffset(Offset = "0x27DB0")]
		public static readonly AnimationParameter State_StunGunDryFireIdle;

		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0x27DE0")]
		public static readonly AnimationParameter State_StunGunFire;

		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x27E10")]
		public static readonly AnimationParameter State_StunGunFirstTimeEquip;

		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		[FieldOffset(Offset = "0x27E40")]
		public static readonly AnimationParameter State_StunGunGearUpEquip;

		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		[FieldOffset(Offset = "0x27E70")]
		public static readonly AnimationParameter State_StunGunHeldToIdle;

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0x27EA0")]
		public static readonly AnimationParameter State_StunGunIdleHeld;

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0x27ED0")]
		public static readonly AnimationParameter State_StunGunIdleToHeld;

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x27F00")]
		public static readonly AnimationParameter State_StunGunReload;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x27F30")]
		public static readonly AnimationParameter State_StunShrine;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x27F60")]
		public static readonly AnimationParameter State_Swim;

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x27F90")]
		public static readonly AnimationParameter State_swimDeath;

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x27FC0")]
		public static readonly AnimationParameter State_swimEnterCave;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x27FF0")]
		public static readonly AnimationParameter State_swimExitCave;

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x28020")]
		public static readonly AnimationParameter State_SwimFast;

		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x28050")]
		public static readonly AnimationParameter State_swimForward;

		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		[FieldOffset(Offset = "0x28080")]
		public static readonly AnimationParameter State_SwimForwardToSwimIdle;

		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x280B0")]
		public static readonly AnimationParameter State_swimIdle;

		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x280E0")]
		public static readonly AnimationParameter State_swimUnderWater;

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4000E72")]
		[FieldOffset(Offset = "0x28110")]
		public static readonly AnimationParameter State_Swing;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000E73")]
		[FieldOffset(Offset = "0x28140")]
		public static readonly AnimationParameter State_swingAxeFB;

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x28170")]
		public static readonly AnimationParameter State_swingAxeFB_0;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x281A0")]
		public static readonly AnimationParameter State_swingAxeHitToIdle;

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x281D0")]
		public static readonly AnimationParameter State_swingAxeMiss;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x28200")]
		public static readonly AnimationParameter State_swingAxeMissToIdle;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x28230")]
		public static readonly AnimationParameter State_swingAxeTransition;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x28260")]
		public static readonly AnimationParameter State_swingLeftReturn;

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x28290")]
		public static readonly AnimationParameter State_swingRight;

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000E7B")]
		[FieldOffset(Offset = "0x282C0")]
		public static readonly AnimationParameter State_SwingToLeftA;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x282F0")]
		public static readonly AnimationParameter State_SwingToLeftAOnHit;

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x28320")]
		public static readonly AnimationParameter State_SwingToLeftB;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x28350")]
		public static readonly AnimationParameter State_SwingToLeftBOnHit;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x28380")]
		public static readonly AnimationParameter State_SwingToRightA;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x283B0")]
		public static readonly AnimationParameter State_SwingToRightAOnHit;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x283E0")]
		public static readonly AnimationParameter State_SwingToRightB;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x28410")]
		public static readonly AnimationParameter State_SwingToRightBOnHit;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x28440")]
		public static readonly AnimationParameter State_Switch_Off;

		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0x28470")]
		public static readonly AnimationParameter State_Switch_On;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000E85")]
		[FieldOffset(Offset = "0x284A0")]
		public static readonly AnimationParameter State_tackleBox_close;

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		[FieldOffset(Offset = "0x284D0")]
		public static readonly AnimationParameter State_tackleBox_closed;

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x28500")]
		public static readonly AnimationParameter State_tackleBox_open;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x28530")]
		public static readonly AnimationParameter State_TacticalAxeAttackGround1;

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x28560")]
		public static readonly AnimationParameter State_TacticalAxeBlock1;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x28590")]
		public static readonly AnimationParameter State_TacticalAxeBlock2;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x285C0")]
		public static readonly AnimationParameter State_TacticalAxeBlockHit1;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x285F0")]
		public static readonly AnimationParameter State_TacticalAxeBlockHit2;

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x28620")]
		public static readonly AnimationParameter State_TacticalAxeBlockToIdle;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x28650")]
		public static readonly AnimationParameter State_TacticalAxeCraftEmptyBag;

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0x28680")]
		public static readonly AnimationParameter State_TacticalAxeHeavyAttack;

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0x286B0")]
		public static readonly AnimationParameter State_TacticalAxeHeavyAttack_TEST;

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0x286E0")]
		public static readonly AnimationParameter State_TacticalAxeHeavyAttackWindup;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x28710")]
		public static readonly AnimationParameter State_TacticalAxeIdle;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x28740")]
		public static readonly AnimationParameter State_TacticalAxeParry;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0x28770")]
		public static readonly AnimationParameter State_TacticalAxeShove;

		// Token: 0x04000E95 RID: 3733
		[Token(Token = "0x4000E95")]
		[FieldOffset(Offset = "0x287A0")]
		public static readonly AnimationParameter State_TacticalAxeToAxeAttack;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x287D0")]
		public static readonly AnimationParameter State_tacticalBowIdle;

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x28800")]
		public static readonly AnimationParameter State_tacticalBowIdleToIdle;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x28830")]
		public static readonly AnimationParameter State_TacticalChainsawIdle;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0x28860")]
		public static readonly AnimationParameter State_TacticalRebreatherIdle;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x28890")]
		public static readonly AnimationParameter State_TacticalRebreatherLower;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x288C0")]
		public static readonly AnimationParameter State_TacticalRebreatherPutOnRebreather;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x288F0")]
		public static readonly AnimationParameter State_TacticalRebreatherRaise;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x28920")]
		public static readonly AnimationParameter State_Take_001;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x28950")]
		public static readonly AnimationParameter State_Take_001_0;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x28980")]
		public static readonly AnimationParameter State_TakeOff;

		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x289B0")]
		public static readonly AnimationParameter State_TakeOffFromGround;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x289E0")]
		public static readonly AnimationParameter State_TarpEquip;

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		[FieldOffset(Offset = "0x28A10")]
		public static readonly AnimationParameter State_TarpIdle;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x28A40")]
		public static readonly AnimationParameter State_TaserStickAttackToLeftA;

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x28A70")]
		public static readonly AnimationParameter State_TaserStickAttackToRightA;

		// Token: 0x04000EA5 RID: 3749
		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0x28AA0")]
		public static readonly AnimationParameter State_TaserStickBlock1;

		// Token: 0x04000EA6 RID: 3750
		[Token(Token = "0x4000EA6")]
		[FieldOffset(Offset = "0x28AD0")]
		public static readonly AnimationParameter State_TaserStickBlock2;

		// Token: 0x04000EA7 RID: 3751
		[Token(Token = "0x4000EA7")]
		[FieldOffset(Offset = "0x28B00")]
		public static readonly AnimationParameter State_TaserStickBlockedLeftA;

		// Token: 0x04000EA8 RID: 3752
		[Token(Token = "0x4000EA8")]
		[FieldOffset(Offset = "0x28B30")]
		public static readonly AnimationParameter State_TaserStickBlockedRightA;

		// Token: 0x04000EA9 RID: 3753
		[Token(Token = "0x4000EA9")]
		[FieldOffset(Offset = "0x28B60")]
		public static readonly AnimationParameter State_TaserStickBlockHit1;

		// Token: 0x04000EAA RID: 3754
		[Token(Token = "0x4000EAA")]
		[FieldOffset(Offset = "0x28B90")]
		public static readonly AnimationParameter State_TaserStickBlockHit2;

		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000EAB")]
		[FieldOffset(Offset = "0x28BC0")]
		public static readonly AnimationParameter State_TaserStickBlockToIdle;

		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000EAC")]
		[FieldOffset(Offset = "0x28BF0")]
		public static readonly AnimationParameter State_TaserStickEquip;

		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x28C20")]
		public static readonly AnimationParameter State_TaserStickFirstTime;

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x28C50")]
		public static readonly AnimationParameter State_TaserStickGround;

		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4000EAF")]
		[FieldOffset(Offset = "0x28C80")]
		public static readonly AnimationParameter State_TaserStickHeavyAttack;

		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000EB0")]
		[FieldOffset(Offset = "0x28CB0")]
		public static readonly AnimationParameter State_TaserStickHeavyAttackWindup;

		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000EB1")]
		[FieldOffset(Offset = "0x28CE0")]
		public static readonly AnimationParameter State_TaserStickIdle;

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x28D10")]
		public static readonly AnimationParameter State_TaserStickJab;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x28D40")]
		public static readonly AnimationParameter State_TaserStickJabIdle;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x28D70")]
		public static readonly AnimationParameter State_TaserStickJabToIdle;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0x28DA0")]
		public static readonly AnimationParameter State_TaserStickMove;

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0x28DD0")]
		public static readonly AnimationParameter State_TaserStickParry;

		// Token: 0x04000EB7 RID: 3767
		[Token(Token = "0x4000EB7")]
		[FieldOffset(Offset = "0x28E00")]
		public static readonly AnimationParameter State_TaserStickShove;

		// Token: 0x04000EB8 RID: 3768
		[Token(Token = "0x4000EB8")]
		[FieldOffset(Offset = "0x28E30")]
		public static readonly AnimationParameter State_TaserStickSwingLeftReturn;

		// Token: 0x04000EB9 RID: 3769
		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0x28E60")]
		public static readonly AnimationParameter State_TaserStickSwingRight;

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x28E90")]
		public static readonly AnimationParameter State_Taunt;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x28EC0")]
		public static readonly AnimationParameter State_TauntA;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x28EF0")]
		public static readonly AnimationParameter State_TauntB;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x28F20")]
		public static readonly AnimationParameter State_TauntC;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x28F50")]
		public static readonly AnimationParameter State_TauntDanceB;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x28F80")]
		public static readonly AnimationParameter State_TauntMedium02;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x28FB0")]
		public static readonly AnimationParameter State_TauntScream;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x28FE0")]
		public static readonly AnimationParameter State_TauntScream01;

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x29010")]
		public static readonly AnimationParameter State_TauntSmall01;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x29040")]
		public static readonly AnimationParameter State_TauntSmall03;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		[FieldOffset(Offset = "0x29070")]
		public static readonly AnimationParameter State_TauntSmallA;

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x290A0")]
		public static readonly AnimationParameter State_TauntSmallB;

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x290D0")]
		public static readonly AnimationParameter State_TauntWild;

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x29100")]
		public static readonly AnimationParameter State_TechArmourCraftTechArmor;

		// Token: 0x04000EC8 RID: 3784
		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x29130")]
		public static readonly AnimationParameter State_TechArmourIdle;

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x29160")]
		public static readonly AnimationParameter State_TechMeshCraftTechArmor;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x29190")]
		public static readonly AnimationParameter State_TechMeshIdle;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x291C0")]
		public static readonly AnimationParameter State_TempState;

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x291F0")]
		public static readonly AnimationParameter State_Test;

		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000ECD")]
		[FieldOffset(Offset = "0x29220")]
		public static readonly AnimationParameter State_TestWindAnimation;

		// Token: 0x04000ECE RID: 3790
		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x29250")]
		public static readonly AnimationParameter State_ThrowBall;

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x29280")]
		public static readonly AnimationParameter State_ThrowBall_0;

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x292B0")]
		public static readonly AnimationParameter State_ThrowCan;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x292E0")]
		public static readonly AnimationParameter State_throwerIdle;

		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x29310")]
		public static readonly AnimationParameter State_throwerRelease;

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x29340")]
		public static readonly AnimationParameter State_ThrowRock;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x29370")]
		public static readonly AnimationParameter State_ThrowRockA;

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x293A0")]
		public static readonly AnimationParameter State_ThrowRockB;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x293D0")]
		public static readonly AnimationParameter State_throwSpear;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x29400")]
		public static readonly AnimationParameter State_ThrowTimeBomb;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x29430")]
		public static readonly AnimationParameter State_ThumbsUp;

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x29460")]
		public static readonly AnimationParameter State_ThumbsUpReaction;

		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x29490")]
		public static readonly AnimationParameter State_TimeBombCraftTimeBomb;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x294C0")]
		public static readonly AnimationParameter State_TimeBombIdle;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x294F0")]
		public static readonly AnimationParameter State_TimmyTurnEnterCave;

		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x29520")]
		public static readonly AnimationParameter State_toAimIdle;

		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x29550")]
		public static readonly AnimationParameter State_toAimIdle_0;

		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x29580")]
		public static readonly AnimationParameter State_ToAimNotched;

		// Token: 0x04000EE0 RID: 3808
		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0x295B0")]
		public static readonly AnimationParameter State_ToAimNotchedFar;

		// Token: 0x04000EE1 RID: 3809
		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0x295E0")]
		public static readonly AnimationParameter State_ToAimPilarUnderBeam;

		// Token: 0x04000EE2 RID: 3810
		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x29610")]
		public static readonly AnimationParameter State_ToAimPilarUnderBeamR;

		// Token: 0x04000EE3 RID: 3811
		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0x29640")]
		public static readonly AnimationParameter State_ToAimPlantPilarIdle;

		// Token: 0x04000EE4 RID: 3812
		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x29670")]
		public static readonly AnimationParameter State_ToAimPlantPilarIdleR;

		// Token: 0x04000EE5 RID: 3813
		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x296A0")]
		public static readonly AnimationParameter State_ToAimRoof;

		// Token: 0x04000EE6 RID: 3814
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x296D0")]
		public static readonly AnimationParameter State_ToAimStrutUnderBeam;

		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x29700")]
		public static readonly AnimationParameter State_toArtifactIdle;

		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x29730")]
		public static readonly AnimationParameter State_toArtifactIdle_0;

		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x29760")]
		public static readonly AnimationParameter State_toBinocularIdle;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x29790")]
		public static readonly AnimationParameter State_toBinocularIdle_0;

		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x297C0")]
		public static readonly AnimationParameter State_toBinocularsLook;

		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x297F0")]
		public static readonly AnimationParameter State_toBinocularsLook_0;

		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x29820")]
		public static readonly AnimationParameter State_toBookIdle;

		// Token: 0x04000EEE RID: 3822
		[Token(Token = "0x4000EEE")]
		[FieldOffset(Offset = "0x29850")]
		public static readonly AnimationParameter State_toCamCorderIdle;

		// Token: 0x04000EEF RID: 3823
		[Token(Token = "0x4000EEF")]
		[FieldOffset(Offset = "0x29880")]
		public static readonly AnimationParameter State_toCamCorderIdle_0;

		// Token: 0x04000EF0 RID: 3824
		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x298B0")]
		public static readonly AnimationParameter State_toCampIdle;

		// Token: 0x04000EF1 RID: 3825
		[Token(Token = "0x4000EF1")]
		[FieldOffset(Offset = "0x298E0")]
		public static readonly AnimationParameter State_toChainSawAttack;

		// Token: 0x04000EF2 RID: 3826
		[Token(Token = "0x4000EF2")]
		[FieldOffset(Offset = "0x29910")]
		public static readonly AnimationParameter State_toChainSawAttack_0;

		// Token: 0x04000EF3 RID: 3827
		[Token(Token = "0x4000EF3")]
		[FieldOffset(Offset = "0x29940")]
		public static readonly AnimationParameter State_toChainsawIdle;

		// Token: 0x04000EF4 RID: 3828
		[Token(Token = "0x4000EF4")]
		[FieldOffset(Offset = "0x29970")]
		public static readonly AnimationParameter State_toChainsawIdle_0;

		// Token: 0x04000EF5 RID: 3829
		[Token(Token = "0x4000EF5")]
		[FieldOffset(Offset = "0x299A0")]
		public static readonly AnimationParameter State_toChainsawIdle_old;

		// Token: 0x04000EF6 RID: 3830
		[Token(Token = "0x4000EF6")]
		[FieldOffset(Offset = "0x299D0")]
		public static readonly AnimationParameter State_toCrossbowIdle;

		// Token: 0x04000EF7 RID: 3831
		[Token(Token = "0x4000EF7")]
		[FieldOffset(Offset = "0x29A00")]
		public static readonly AnimationParameter State_toCrossbowIdle_0;

		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x29A30")]
		public static readonly AnimationParameter State_toCrossbowIdleEmpty;

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x29A60")]
		public static readonly AnimationParameter State_toDrowningOnBack;

		// Token: 0x04000EFA RID: 3834
		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0x29A90")]
		public static readonly AnimationParameter State_toFlameThrowerAttack;

		// Token: 0x04000EFB RID: 3835
		[Token(Token = "0x4000EFB")]
		[FieldOffset(Offset = "0x29AC0")]
		public static readonly AnimationParameter State_toFlameThrowerIdle;

		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		[FieldOffset(Offset = "0x29AF0")]
		public static readonly AnimationParameter State_toFlameThrowerIdle_0;

		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x29B20")]
		public static readonly AnimationParameter State_toFlareAimIdle;

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x29B50")]
		public static readonly AnimationParameter State_toFlareAimIdle_0;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x29B80")]
		public static readonly AnimationParameter State_toFlareGunIdle;

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x29BB0")]
		public static readonly AnimationParameter State_toFlareGunIdle_0;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x29BE0")]
		public static readonly AnimationParameter State_toFlashlightIdle;

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x29C10")]
		public static readonly AnimationParameter State_toFlashlightIdle_0;

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x29C40")]
		public static readonly AnimationParameter State_toFlashlightIdleRifle;

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x29C70")]
		public static readonly AnimationParameter State_toGliderIdle;

		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		[FieldOffset(Offset = "0x29CA0")]
		public static readonly AnimationParameter State_toGliderIdleFlying;

		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		[FieldOffset(Offset = "0x29CD0")]
		public static readonly AnimationParameter State_toIdle;

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x29D00")]
		public static readonly AnimationParameter State_toLookAtPhoto;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x29D30")]
		public static readonly AnimationParameter State_toLookLeft;

		// Token: 0x04000F09 RID: 3849
		[Token(Token = "0x4000F09")]
		[FieldOffset(Offset = "0x29D60")]
		public static readonly AnimationParameter State_toLookRight;

		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x29D90")]
		public static readonly AnimationParameter State_toPistolAim180;

		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x29DC0")]
		public static readonly AnimationParameter State_toPistolAimLeft;

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x29DF0")]
		public static readonly AnimationParameter State_toPistolAimRight;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x29E20")]
		public static readonly AnimationParameter State_ToPlaceFloorIdle;

		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x29E50")]
		public static readonly AnimationParameter State_ToPlaceFloorIdleR;

		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		[FieldOffset(Offset = "0x29E80")]
		public static readonly AnimationParameter State_ToPlaceHorizontalIdle;

		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x29EB0")]
		public static readonly AnimationParameter State_ToPlaceHorizontalIdleR;

		// Token: 0x04000F11 RID: 3857
		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x29EE0")]
		public static readonly AnimationParameter State_toPotHeld;

		// Token: 0x04000F12 RID: 3858
		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x29F10")]
		public static readonly AnimationParameter State_toPotHeld_0;

		// Token: 0x04000F13 RID: 3859
		[Token(Token = "0x4000F13")]
		[FieldOffset(Offset = "0x29F40")]
		public static readonly AnimationParameter State_TorchCraftCraftedTorch;

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x29F70")]
		public static readonly AnimationParameter State_TorchGroundAttack;

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x29FA0")]
		public static readonly AnimationParameter State_TorchIdle;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x29FD0")]
		public static readonly AnimationParameter State_toRockIdleHigh;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x2A000")]
		public static readonly AnimationParameter State_toRockIdleHigh_1;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x2A030")]
		public static readonly AnimationParameter State_ToRopeGunAim;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0x2A060")]
		public static readonly AnimationParameter State_toShellRide;

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x2A090")]
		public static readonly AnimationParameter State_toShotgunAim;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x2A0C0")]
		public static readonly AnimationParameter State_toShotgunAim_0;

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x2A0F0")]
		public static readonly AnimationParameter State_toShotgunAim_1;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x2A120")]
		public static readonly AnimationParameter State_toShotgunAimDown;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x2A150")]
		public static readonly AnimationParameter State_toShotgunGidle;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x2A180")]
		public static readonly AnimationParameter State_toShotgunGidle_0;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x2A1B0")]
		public static readonly AnimationParameter State_toShotgunGidle_1;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x2A1E0")]
		public static readonly AnimationParameter State_toShovelDig;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x2A210")]
		public static readonly AnimationParameter State_toShovelIdle;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x2A240")]
		public static readonly AnimationParameter State_toSitIdle;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x2A270")]
		public static readonly AnimationParameter State_toSlingShotAim;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x2A2A0")]
		public static readonly AnimationParameter State_toSlingShotAim_0;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x2A2D0")]
		public static readonly AnimationParameter State_toSlingShotIdle;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0x2A300")]
		public static readonly AnimationParameter State_toSlingShotIdle_0;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x2A330")]
		public static readonly AnimationParameter State_toThrowerIdle;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0x2A360")]
		public static readonly AnimationParameter State_toTreeSaw;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x2A390")]
		public static readonly AnimationParameter State_toTreeSaw_0;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x2A3C0")]
		public static readonly AnimationParameter State_toTreeSaw_0_0;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x2A3F0")]
		public static readonly AnimationParameter State_toTreeSaw_1;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x2A420")]
		public static readonly AnimationParameter State_toWalk180;

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x2A450")]
		public static readonly AnimationParameter State_toWalkLeft;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x2A480")]
		public static readonly AnimationParameter State_toWalkRight;

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x2A4B0")]
		public static readonly AnimationParameter State_towaterSkinHeld;

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x2A4E0")]
		public static readonly AnimationParameter State_towaterSkinHeld_0;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x2A510")]
		public static readonly AnimationParameter State_TrackerFirstTimeEquip;

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x2A540")]
		public static readonly AnimationParameter State_TrackerHeldToIdle;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x2A570")]
		public static readonly AnimationParameter State_TrackerHeldWideExtraToIdle;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x2A5A0")]
		public static readonly AnimationParameter State_TrackerIdleheld;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x2A5D0")]
		public static readonly AnimationParameter State_TrackerIdleHeldGliderFly;

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x2A600")]
		public static readonly AnimationParameter State_TrackerIdleheldPistol;

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0x2A630")]
		public static readonly AnimationParameter State_TrackerIdleHeldRifle;

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x2A660")]
		public static readonly AnimationParameter State_TrackerIdleHeldRopegun;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x2A690")]
		public static readonly AnimationParameter State_TrackerIdleheldWide;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x2A6C0")]
		public static readonly AnimationParameter State_TrackerIdleheldWideExtra;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x2A6F0")]
		public static readonly AnimationParameter State_TrackerIdleToGliderFly;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x2A720")]
		public static readonly AnimationParameter State_TrackerIdleToHeld;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x2A750")]
		public static readonly AnimationParameter State_TrackerIdleToHeldPistol;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x2A780")]
		public static readonly AnimationParameter State_TrackerIdleToHeldWide;

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0x2A7B0")]
		public static readonly AnimationParameter State_TrackerIdleToHeldWideExtra;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x2A7E0")]
		public static readonly AnimationParameter State_Trailer1_virginiaRamapge_camera;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x2A810")]
		public static readonly AnimationParameter State_Trailer1_virginiaRampage_environment;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x2A840")]
		public static readonly AnimationParameter State_Trailer1_virginiaRampage_virginia;

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x2A870")]
		public static readonly AnimationParameter State_Transition_Auto_Delay;

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x4000F45")]
		[FieldOffset(Offset = "0x2A8A0")]
		public static readonly AnimationParameter State_Transition_Auto_In;

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x4000F46")]
		[FieldOffset(Offset = "0x2A8D0")]
		public static readonly AnimationParameter State_Transition_Auto_Loop;

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x2A900")]
		public static readonly AnimationParameter State_Transition_Auto_Out;

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x2A930")]
		public static readonly AnimationParameter State_Transition_Delay;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x2A960")]
		public static readonly AnimationParameter State_Transition_In;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x2A990")]
		public static readonly AnimationParameter State_Transition_In_Delay;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x2A9C0")]
		public static readonly AnimationParameter State_Transition_Loop;

		// Token: 0x04000F4C RID: 3916
		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0x2A9F0")]
		public static readonly AnimationParameter State_Transition_Out;

		// Token: 0x04000F4D RID: 3917
		[Token(Token = "0x4000F4D")]
		[FieldOffset(Offset = "0x2AA20")]
		public static readonly AnimationParameter State_Transition_Out_Delay;

		// Token: 0x04000F4E RID: 3918
		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x2AA50")]
		public static readonly AnimationParameter State_TrapIdle;

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x2AA80")]
		public static readonly AnimationParameter State_TreeChopIdle;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x2AAB0")]
		public static readonly AnimationParameter State_TreeChopIdleToIdle;

		// Token: 0x04000F51 RID: 3921
		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x2AAE0")]
		public static readonly AnimationParameter State_TreeChopSwing01;

		// Token: 0x04000F52 RID: 3922
		[Token(Token = "0x4000F52")]
		[FieldOffset(Offset = "0x2AB10")]
		public static readonly AnimationParameter State_TreeChopSwing02;

		// Token: 0x04000F53 RID: 3923
		[Token(Token = "0x4000F53")]
		[FieldOffset(Offset = "0x2AB40")]
		public static readonly AnimationParameter State_TreeChopSwingToITreeChopdle;

		// Token: 0x04000F54 RID: 3924
		[Token(Token = "0x4000F54")]
		[FieldOffset(Offset = "0x2AB70")]
		public static readonly AnimationParameter State_TreeCrashBadGuyIntro;

		// Token: 0x04000F55 RID: 3925
		[Token(Token = "0x4000F55")]
		[FieldOffset(Offset = "0x2ABA0")]
		public static readonly AnimationParameter State_TreeCrashPilot;

		// Token: 0x04000F56 RID: 3926
		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x2ABD0")]
		public static readonly AnimationParameter State_TreeCrashPlayer;

		// Token: 0x04000F57 RID: 3927
		[Token(Token = "0x4000F57")]
		[FieldOffset(Offset = "0x2AC00")]
		public static readonly AnimationParameter State_TreeCrashStandup;

		// Token: 0x04000F58 RID: 3928
		[Token(Token = "0x4000F58")]
		[FieldOffset(Offset = "0x2AC30")]
		public static readonly AnimationParameter State_TreeCrashTactiA;

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x2AC60")]
		public static readonly AnimationParameter State_TreeCrashTactiB;

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0x2AC90")]
		public static readonly AnimationParameter State_TreeCut;

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x2ACC0")]
		public static readonly AnimationParameter State_TreeCutToIdle;

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x2ACF0")]
		public static readonly AnimationParameter State_TreeJumpToTree;

		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0x2AD20")]
		public static readonly AnimationParameter State_treeSaw;

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x2AD50")]
		public static readonly AnimationParameter State_treeSaw_0;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x2AD80")]
		public static readonly AnimationParameter State_TreeShimmyLeft;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x2ADB0")]
		public static readonly AnimationParameter State_TreeShimmyRight;

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0x2ADE0")]
		public static readonly AnimationParameter State_TreeTaunt;

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0x2AE10")]
		public static readonly AnimationParameter State_TriggerTrap;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		[FieldOffset(Offset = "0x2AE40")]
		public static readonly AnimationParameter State_Trot;

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x2AE70")]
		public static readonly AnimationParameter State_trot_loop;

		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x2AEA0")]
		public static readonly AnimationParameter State_TrotToIdle;

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x2AED0")]
		public static readonly AnimationParameter State_Turn180;

		// Token: 0x04000F67 RID: 3943
		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x2AF00")]
		public static readonly AnimationParameter State_Turn180Fast;

		// Token: 0x04000F68 RID: 3944
		[Token(Token = "0x4000F68")]
		[FieldOffset(Offset = "0x2AF30")]
		public static readonly AnimationParameter State_Turn180Fast1;

		// Token: 0x04000F69 RID: 3945
		[Token(Token = "0x4000F69")]
		[FieldOffset(Offset = "0x2AF60")]
		public static readonly AnimationParameter State_Turn180FastAttack;

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		[FieldOffset(Offset = "0x2AF90")]
		public static readonly AnimationParameter State_Turn180Left;

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x2AFC0")]
		public static readonly AnimationParameter State_Turn180Right;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x2AFF0")]
		public static readonly AnimationParameter State_Turn90Left;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x2B020")]
		public static readonly AnimationParameter State_Turn90LeftFast;

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x2B050")]
		public static readonly AnimationParameter State_Turn90Right;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x2B080")]
		public static readonly AnimationParameter State_Turn90RightFast;

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x2B0B0")]
		public static readonly AnimationParameter State_TurnAroundCombat;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x2B0E0")]
		public static readonly AnimationParameter State_TurnAroundFast;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x2B110")]
		public static readonly AnimationParameter State_TurnLeft;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x2B140")]
		public static readonly AnimationParameter State_turnLeft90;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x2B170")]
		public static readonly AnimationParameter State_TurnLeftCombat;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x2B1A0")]
		public static readonly AnimationParameter State_TurnLeftCrouch;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x2B1D0")]
		public static readonly AnimationParameter State_TurnLeftFast;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x2B200")]
		public static readonly AnimationParameter State_TurnLeftStartle;

		// Token: 0x04000F78 RID: 3960
		[Token(Token = "0x4000F78")]
		[FieldOffset(Offset = "0x2B230")]
		public static readonly AnimationParameter State_turnLeftToIdle;

		// Token: 0x04000F79 RID: 3961
		[Token(Token = "0x4000F79")]
		[FieldOffset(Offset = "0x2B260")]
		public static readonly AnimationParameter State_turnLeftToIdleCrouch;

		// Token: 0x04000F7A RID: 3962
		[Token(Token = "0x4000F7A")]
		[FieldOffset(Offset = "0x2B290")]
		public static readonly AnimationParameter State_TurnOnSpot;

		// Token: 0x04000F7B RID: 3963
		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x2B2C0")]
		public static readonly AnimationParameter State_TurnRight;

		// Token: 0x04000F7C RID: 3964
		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x2B2F0")]
		public static readonly AnimationParameter State_turnRight180;

		// Token: 0x04000F7D RID: 3965
		[Token(Token = "0x4000F7D")]
		[FieldOffset(Offset = "0x2B320")]
		public static readonly AnimationParameter State_turnRight90;

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x2B350")]
		public static readonly AnimationParameter State_TurnRightCombat;

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x2B380")]
		public static readonly AnimationParameter State_TurnRightCrouch;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x2B3B0")]
		public static readonly AnimationParameter State_TurnRightFast;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x2B3E0")]
		public static readonly AnimationParameter State_TurnRightStartle;

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x2B410")]
		public static readonly AnimationParameter State_turnRightToIdle;

		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x2B440")]
		public static readonly AnimationParameter State_turnRightToIdleCrouch;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x2B470")]
		public static readonly AnimationParameter State_TurnSharpLeft;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x2B4A0")]
		public static readonly AnimationParameter State_TurnSharpRight;

		// Token: 0x04000F86 RID: 3974
		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x2B4D0")]
		public static readonly AnimationParameter State_TurtleCrawlForward;

		// Token: 0x04000F87 RID: 3975
		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0x2B500")]
		public static readonly AnimationParameter State_TurtleDie;

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x2B530")]
		public static readonly AnimationParameter State_TurtleEat;

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x2B560")]
		public static readonly AnimationParameter State_TurtleGetHit;

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x2B590")]
		public static readonly AnimationParameter State_TurtleIdle;

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		[FieldOffset(Offset = "0x2B5C0")]
		public static readonly AnimationParameter State_TurtleLayEgg;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		[FieldOffset(Offset = "0x2B5F0")]
		public static readonly AnimationParameter State_TurtleSleepLand;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		[FieldOffset(Offset = "0x2B620")]
		public static readonly AnimationParameter State_TurtleSleepWater;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		[FieldOffset(Offset = "0x2B650")]
		public static readonly AnimationParameter State_TurtleStepBack;

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		[FieldOffset(Offset = "0x2B680")]
		public static readonly AnimationParameter State_TurtleSwim;

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		[FieldOffset(Offset = "0x2B6B0")]
		public static readonly AnimationParameter State_TurtleTurnLeft;

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		[FieldOffset(Offset = "0x2B6E0")]
		public static readonly AnimationParameter State_TurtleTurnRight;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0x2B710")]
		public static readonly AnimationParameter State_TutorialBookCraftEmptyBag;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		[FieldOffset(Offset = "0x2B740")]
		public static readonly AnimationParameter State_TutorialBookEquip;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		[FieldOffset(Offset = "0x2B770")]
		public static readonly AnimationParameter State_TutorialBookFirstLook;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0x2B7A0")]
		public static readonly AnimationParameter State_TutorialBookFlipPageBack;

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		[FieldOffset(Offset = "0x2B7D0")]
		public static readonly AnimationParameter State_TutorialBookFlipPageForward;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		[FieldOffset(Offset = "0x2B800")]
		public static readonly AnimationParameter State_TutorialBookIdle;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		[FieldOffset(Offset = "0x2B830")]
		public static readonly AnimationParameter State_TutorialBookLeftHandEquip;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0x2B860")]
		public static readonly AnimationParameter State_TutorialBookLeftHandFlipPageBack;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x2B890")]
		public static readonly AnimationParameter State_TutorialBookLeftHandFlipPageForward;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x2B8C0")]
		public static readonly AnimationParameter State_TutorialBookLeftHandIdle;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x2B8F0")]
		public static readonly AnimationParameter State_TutorialBookLeftHandUnequip;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x2B920")]
		public static readonly AnimationParameter State_TutorialBookUnequip;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x2B950")]
		public static readonly AnimationParameter State_TutorialPageEquip;

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x2B980")]
		public static readonly AnimationParameter State_TutorialPageIdle;

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x2B9B0")]
		public static readonly AnimationParameter State_TutorialPageUnequip;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x2B9E0")]
		public static readonly AnimationParameter State_TwinberriesCraftLootPouch;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x2BA10")]
		public static readonly AnimationParameter State_TwinberriesIdle;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x2BA40")]
		public static readonly AnimationParameter State_TwinsWalkForwardFast;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x2BA70")]
		public static readonly AnimationParameter State_Underground;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0x2BAA0")]
		public static readonly AnimationParameter State_UnEquipRepairTool;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0x2BAD0")]
		public static readonly AnimationParameter State_unload;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x2BB00")]
		public static readonly AnimationParameter State_unRoll;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x2BB30")]
		public static readonly AnimationParameter State_VirginiaHideBehindTree;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0x2BB60")]
		public static readonly AnimationParameter State_VirginiaHideBehindTreeToIdle;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x2BB90")]
		public static readonly AnimationParameter State_VirginiaIdleToHideBehindTree;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x2BBC0")]
		public static readonly AnimationParameter State_VirginiaMissingCut;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x2BBF0")]
		public static readonly AnimationParameter State_VirginiaSleepIdleA;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x2BC20")]
		public static readonly AnimationParameter State_VirginiaSleepIdleB;

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x2BC50")]
		public static readonly AnimationParameter State_VirginiaSleepIdleBed;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x2BC80")]
		public static readonly AnimationParameter State_VirginiaWakeUpA;

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0x2BCB0")]
		public static readonly AnimationParameter State_VirginiaWakeUpB;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x2BCE0")]
		public static readonly AnimationParameter State_VirginiaWakeUpBed;

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x2BD10")]
		public static readonly AnimationParameter State_VodkaBottleCraftMolotov;

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x2BD40")]
		public static readonly AnimationParameter State_VodkaBottleIdle;

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x2BD70")]
		public static readonly AnimationParameter State_Wait;

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x2BDA0")]
		public static readonly AnimationParameter State_wait;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x2BDD0")]
		public static readonly AnimationParameter State_WaitForPlayer;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x2BE00")]
		public static readonly AnimationParameter State_WakeOnEffigyIdle;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x2BE30")]
		public static readonly AnimationParameter State_WakeOnEffigyIntro;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x2BE60")]
		public static readonly AnimationParameter State_WakeOnEffigyOutro;

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x2BE90")]
		public static readonly AnimationParameter State_wakeUp;

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		[FieldOffset(Offset = "0x2BEC0")]
		public static readonly AnimationParameter State_WakeUpInSpittleIdle;

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		[FieldOffset(Offset = "0x2BEF0")]
		public static readonly AnimationParameter State_WakeUpInSpittleIntro;

		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		[FieldOffset(Offset = "0x2BF20")]
		public static readonly AnimationParameter State_WakeUpInSpittleOutro;

		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		[FieldOffset(Offset = "0x2BF50")]
		public static readonly AnimationParameter State_WakeUpOnBeach;

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x2BF80")]
		public static readonly AnimationParameter State_WakeUpUnderBodiesIdle;

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x2BFB0")]
		public static readonly AnimationParameter State_WakeUpUnderBodiesIntro;

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x2BFE0")]
		public static readonly AnimationParameter State_WakeUpUnderBodiesOutro;

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x2C010")]
		public static readonly AnimationParameter State_WakeUpUnderWaterIdle;

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x2C040")]
		public static readonly AnimationParameter State_WakeUpUnderWaterIntro;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x2C070")]
		public static readonly AnimationParameter State_WakeUpUnderWaterOutro;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x2C0A0")]
		public static readonly AnimationParameter State_Walk;

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x2C0D0")]
		public static readonly AnimationParameter State_walk;

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x2C100")]
		public static readonly AnimationParameter State_Walk_B;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0x2C130")]
		public static readonly AnimationParameter State_Walk_F;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x2C160")]
		public static readonly AnimationParameter State_Walk_L;

		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x2C190")]
		public static readonly AnimationParameter State_Walk_LB;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x2C1C0")]
		public static readonly AnimationParameter State_Walk_LF;

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x2C1F0")]
		public static readonly AnimationParameter State_Walk_R;

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x2C220")]
		public static readonly AnimationParameter State_Walk_RB;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0x2C250")]
		public static readonly AnimationParameter State_Walk_RF;

		// Token: 0x04000FCF RID: 4047
		[Token(Token = "0x4000FCF")]
		[FieldOffset(Offset = "0x2C280")]
		public static readonly AnimationParameter State_walk_idle;

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0x2C2B0")]
		public static readonly AnimationParameter State_walk_loop;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x2C2E0")]
		public static readonly AnimationParameter State_WalkAggressive;

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x2C310")]
		public static readonly AnimationParameter State_WalkAggressiveFemale;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x2C340")]
		public static readonly AnimationParameter State_WalkAggressiveToIdle;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x2C370")]
		public static readonly AnimationParameter State_WalkAggressiveToIdleFemale;

		// Token: 0x04000FD5 RID: 4053
		[Token(Token = "0x4000FD5")]
		[FieldOffset(Offset = "0x2C3A0")]
		public static readonly AnimationParameter State_WalkAggressiveToTurn180;

		// Token: 0x04000FD6 RID: 4054
		[Token(Token = "0x4000FD6")]
		[FieldOffset(Offset = "0x2C3D0")]
		public static readonly AnimationParameter State_WalkAggressiveToTurn180Female;

		// Token: 0x04000FD7 RID: 4055
		[Token(Token = "0x4000FD7")]
		[FieldOffset(Offset = "0x2C400")]
		public static readonly AnimationParameter State_WalkAggressiveToTurnLeft;

		// Token: 0x04000FD8 RID: 4056
		[Token(Token = "0x4000FD8")]
		[FieldOffset(Offset = "0x2C430")]
		public static readonly AnimationParameter State_WalkAggressiveToTurnLeftFemale;

		// Token: 0x04000FD9 RID: 4057
		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0x2C460")]
		public static readonly AnimationParameter State_WalkAggressiveToTurnRight;

		// Token: 0x04000FDA RID: 4058
		[Token(Token = "0x4000FDA")]
		[FieldOffset(Offset = "0x2C490")]
		public static readonly AnimationParameter State_WalkAggressiveToTurnRightFemale;

		// Token: 0x04000FDB RID: 4059
		[Token(Token = "0x4000FDB")]
		[FieldOffset(Offset = "0x2C4C0")]
		public static readonly AnimationParameter State_WalkBack;

		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x2C4F0")]
		public static readonly AnimationParameter State_walkBack;

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x2C520")]
		public static readonly AnimationParameter State_walkBackToIdle;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x2C550")]
		public static readonly AnimationParameter State_WalkBackToIdle;

		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x2C580")]
		public static readonly AnimationParameter State_WalkBackward;

		// Token: 0x04000FE0 RID: 4064
		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x2C5B0")]
		public static readonly AnimationParameter State_WalkBackwardFast;

		// Token: 0x04000FE1 RID: 4065
		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x2C5E0")]
		public static readonly AnimationParameter State_WalkBackwardFastToIdle;

		// Token: 0x04000FE2 RID: 4066
		[Token(Token = "0x4000FE2")]
		[FieldOffset(Offset = "0x2C610")]
		public static readonly AnimationParameter State_WalkBackwardToIdle;

		// Token: 0x04000FE3 RID: 4067
		[Token(Token = "0x4000FE3")]
		[FieldOffset(Offset = "0x2C640")]
		public static readonly AnimationParameter State_walkForward;

		// Token: 0x04000FE4 RID: 4068
		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x2C670")]
		public static readonly AnimationParameter State_WalkForwardAggressive;

		// Token: 0x04000FE5 RID: 4069
		[Token(Token = "0x4000FE5")]
		[FieldOffset(Offset = "0x2C6A0")]
		public static readonly AnimationParameter State_WalkForwardAggressiveToIdle;

		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x2C6D0")]
		public static readonly AnimationParameter State_WalkForwardCrouch;

		// Token: 0x04000FE7 RID: 4071
		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x2C700")]
		public static readonly AnimationParameter State_WalkForwardFast;

		// Token: 0x04000FE8 RID: 4072
		[Token(Token = "0x4000FE8")]
		[FieldOffset(Offset = "0x2C730")]
		public static readonly AnimationParameter State_WalkForwardFastToIdle;

		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x2C760")]
		public static readonly AnimationParameter State_WalkForwardFastToTurn180;

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x2C790")]
		public static readonly AnimationParameter State_WalkForwardFastToTurnLeft;

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x2C7C0")]
		public static readonly AnimationParameter State_WalkForwardFastToTurnRight;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x2C7F0")]
		public static readonly AnimationParameter State_WalkForwardSlow;

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0x2C820")]
		public static readonly AnimationParameter State_WalkForwardSlowToIdle;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x2C850")]
		public static readonly AnimationParameter State_WalkForwardSlowToTurn180;

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0x2C880")]
		public static readonly AnimationParameter State_WalkForwardSlowToTurnLeft;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		[FieldOffset(Offset = "0x2C8B0")]
		public static readonly AnimationParameter State_WalkForwardSlowToTurnRight;

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x2C8E0")]
		public static readonly AnimationParameter State_WalkForwardSmallerBodyOnTop;

		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0x2C910")]
		public static readonly AnimationParameter State_WalkForwardSmallerBodyOnTopToIdleSmallerBodyOnTop;

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0x2C940")]
		public static readonly AnimationParameter State_WalkForwardToTurn180;

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x2C970")]
		public static readonly AnimationParameter State_WalkForwardToTurnLeft;

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x2C9A0")]
		public static readonly AnimationParameter State_WalkForwardToTurnRight;

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x2C9D0")]
		public static readonly AnimationParameter State_WalkieTalkieFirstTimeEquip;

		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x2CA00")]
		public static readonly AnimationParameter State_WalkieTalkieHeldToIdle;

		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x2CA30")]
		public static readonly AnimationParameter State_WalkieTalkieIdleheld;

		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x2CA60")]
		public static readonly AnimationParameter State_WalkieTalkieIdleheldPistol;

		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x2CA90")]
		public static readonly AnimationParameter State_WalkieTalkieIdleheldWide;

		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0x2CAC0")]
		public static readonly AnimationParameter State_WalkieTalkieIdleheldWideExtra;

		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0x2CAF0")]
		public static readonly AnimationParameter State_WalkieTalkieIdleToHeld;

		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0x2CB20")]
		public static readonly AnimationParameter State_WalkieTalkieIdleToHeldPistol;

		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x2CB50")]
		public static readonly AnimationParameter State_WalkieTalkieIdleToHeldWide;

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x2CB80")]
		public static readonly AnimationParameter State_WalkieTalkieIdleToHeldWideExtra;

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0x2CBB0")]
		public static readonly AnimationParameter State_Walking;

		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		[FieldOffset(Offset = "0x2CBE0")]
		public static readonly AnimationParameter State_walkmanIdle;

		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		[FieldOffset(Offset = "0x2CC10")]
		public static readonly AnimationParameter State_walkmanIdle_0;

		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0x2CC40")]
		public static readonly AnimationParameter State_walkmanPlay;

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0x2CC70")]
		public static readonly AnimationParameter State_WalkPassive;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x2CCA0")]
		public static readonly AnimationParameter State_WalkPassiveToIdle;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x2CCD0")]
		public static readonly AnimationParameter State_WalkRun;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x2CD00")]
		public static readonly AnimationParameter State_WalkToIdle;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x2CD30")]
		public static readonly AnimationParameter State_walkToIdle;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x2CD60")]
		public static readonly AnimationParameter State_WalkToSitDownInWater;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x2CD90")]
		public static readonly AnimationParameter State_WalkToSitDownInWaterEnd;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x2CDC0")]
		public static readonly AnimationParameter State_WalkToTurn180;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0x2CDF0")]
		public static readonly AnimationParameter State_WalkToTurnLeft;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0x2CE20")]
		public static readonly AnimationParameter State_WalkToTurnRight;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x2CE50")]
		public static readonly AnimationParameter State_WallCrawlForward;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x2CE80")]
		public static readonly AnimationParameter State_WallCrawlForwardToIdle;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x2CEB0")]
		public static readonly AnimationParameter State_WallCrawlForwardToTurn180;

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x2CEE0")]
		public static readonly AnimationParameter State_WallCrawlForwardToTurnLeft;

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x2CF10")]
		public static readonly AnimationParameter State_WallCrawlForwardToTurnRight;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x2CF40")]
		public static readonly AnimationParameter State_WallIdle;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x2CF70")]
		public static readonly AnimationParameter State_WallIdleToCrawl180;

		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x2CFA0")]
		public static readonly AnimationParameter State_WallIdleToCrawlForward;

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		[FieldOffset(Offset = "0x2CFD0")]
		public static readonly AnimationParameter State_WallIdleToCrawlLeft;

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x2D000")]
		public static readonly AnimationParameter State_WallIdleToCrawlRight;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x2D030")]
		public static readonly AnimationParameter State_WardrobeIdle;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x2D060")]
		public static readonly AnimationParameter State_WashStream;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x2D090")]
		public static readonly AnimationParameter State_WashStreamEnd;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x2D0C0")]
		public static readonly AnimationParameter State_WashWaterfall;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x2D0F0")]
		public static readonly AnimationParameter State_WaterLand;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x2D120")]
		public static readonly AnimationParameter State_waterSkinHeldIdle;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x2D150")]
		public static readonly AnimationParameter State_WipeForhead;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x2D180")]
		public static readonly AnimationParameter State_WireCraftLootPouch;

		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x2D1B0")]
		public static readonly AnimationParameter State_WireCraftTechArmor;

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x2D1E0")]
		public static readonly AnimationParameter State_WireCraftTimeBomb;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x2D210")]
		public static readonly AnimationParameter State_WireEquip;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x2D240")]
		public static readonly AnimationParameter State_WireIdle;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x2D270")]
		public static readonly AnimationParameter State_WireUnequip;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x2D2A0")]
		public static readonly AnimationParameter State_WoundedIdle;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x2D2D0")]
		public static readonly AnimationParameter State_WoundedIdle_0;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x2D300")]
		public static readonly AnimationParameter State_WoundedIdle_0_0;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x2D330")]
		public static readonly AnimationParameter State_WoundedIdle_0_0_0;

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x2D360")]
		public static readonly AnimationParameter State_WoundedIdle_0_1;

		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		[FieldOffset(Offset = "0x2D390")]
		public static readonly AnimationParameter State_WoundedIdle_1;

		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x2D3C0")]
		public static readonly AnimationParameter State_WoundedToShootingKneeling;

		// Token: 0x0400102C RID: 4140
		[Token(Token = "0x400102C")]
		[FieldOffset(Offset = "0x2D3F0")]
		public static readonly AnimationParameter State_WoundedToShootingKneeling_0;

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x2D420")]
		public static readonly AnimationParameter State_WoundedToShootingStanding;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x2D450")]
		public static readonly AnimationParameter State_WristwatchCraftLootPouch;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x2D480")]
		public static readonly AnimationParameter State_WristwatchCraftTimeBomb;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x2D4B0")]
		public static readonly AnimationParameter State_WristwatchIdle;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x2D4E0")]
		public static readonly AnimationParameter State_Writhe;

		// Token: 0x04001032 RID: 4146
		[Token(Token = "0x4001032")]
		[FieldOffset(Offset = "0x2D510")]
		public static readonly AnimationParameter State_Writhe2;

		// Token: 0x04001033 RID: 4147
		[Token(Token = "0x4001033")]
		[FieldOffset(Offset = "0x2D540")]
		public static readonly AnimationParameter State_X_AttackIdle;

		// Token: 0x04001034 RID: 4148
		[Token(Token = "0x4001034")]
		[FieldOffset(Offset = "0x2D570")]
		public static readonly AnimationParameter State_X_CarryLog;

		// Token: 0x04001035 RID: 4149
		[Token(Token = "0x4001035")]
		[FieldOffset(Offset = "0x2D5A0")]
		public static readonly AnimationParameter State_X_carryLog;

		// Token: 0x04001036 RID: 4150
		[Token(Token = "0x4001036")]
		[FieldOffset(Offset = "0x2D5D0")]
		public static readonly AnimationParameter State_X_FallIdle;

		// Token: 0x04001037 RID: 4151
		[Token(Token = "0x4001037")]
		[FieldOffset(Offset = "0x2D600")]
		public static readonly AnimationParameter State_X_hitKnockBack;

		// Token: 0x04001038 RID: 4152
		[Token(Token = "0x4001038")]
		[FieldOffset(Offset = "0x2D630")]
		public static readonly AnimationParameter State_X_hitKnockBackChainsaw;

		// Token: 0x04001039 RID: 4153
		[Token(Token = "0x4001039")]
		[FieldOffset(Offset = "0x2D660")]
		public static readonly AnimationParameter State_X_hitKnockBackCraftedBow;

		// Token: 0x0400103A RID: 4154
		[Token(Token = "0x400103A")]
		[FieldOffset(Offset = "0x2D690")]
		public static readonly AnimationParameter State_X_hitKnockBackMachete;

		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		[FieldOffset(Offset = "0x2D6C0")]
		public static readonly AnimationParameter State_X_hitKnockBackSeveredArm;

		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		[FieldOffset(Offset = "0x2D6F0")]
		public static readonly AnimationParameter State_X_hitKnockBackSeveredLeg;

		// Token: 0x0400103D RID: 4157
		[Token(Token = "0x400103D")]
		[FieldOffset(Offset = "0x2D720")]
		public static readonly AnimationParameter State_X_hitKnockBackShotgun;

		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		[FieldOffset(Offset = "0x2D750")]
		public static readonly AnimationParameter State_X_idle;

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x2D780")]
		public static readonly AnimationParameter State_X_Idle;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x2D7B0")]
		public static readonly AnimationParameter State_X_idleAggressive;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x2D7E0")]
		public static readonly AnimationParameter State_X_idleAttack;

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x2D810")]
		public static readonly AnimationParameter State_X_idleStick;

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x2D840")]
		public static readonly AnimationParameter State_X_IdleTacticalAxe;

		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x2D870")]
		public static readonly AnimationParameter State_X_IdleToCarryLog;

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x2D8A0")]
		public static readonly AnimationParameter State_X_idleToJump;

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x2D8D0")]
		public static readonly AnimationParameter State_X_InventoryKneelIdle;

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x2D900")]
		public static readonly AnimationParameter State_X_InventoryKneelIntro;

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0x2D930")]
		public static readonly AnimationParameter State_X_InventoryKneelOutro;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0x2D960")]
		public static readonly AnimationParameter State_X_JumpOntoZipline;

		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		[FieldOffset(Offset = "0x2D990")]
		public static readonly AnimationParameter State_X_locomotion;

		// Token: 0x0400104B RID: 4171
		[Token(Token = "0x400104B")]
		[FieldOffset(Offset = "0x2D9C0")]
		public static readonly AnimationParameter State_X_molotovIdle;

		// Token: 0x0400104C RID: 4172
		[Token(Token = "0x400104C")]
		[FieldOffset(Offset = "0x2D9F0")]
		public static readonly AnimationParameter State_X_MoveStick;

		// Token: 0x0400104D RID: 4173
		[Token(Token = "0x400104D")]
		[FieldOffset(Offset = "0x2DA20")]
		public static readonly AnimationParameter State_X_potHeldIdle;

		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		[FieldOffset(Offset = "0x2DA50")]
		public static readonly AnimationParameter State_X_PotIdle;

		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		[FieldOffset(Offset = "0x2DA80")]
		public static readonly AnimationParameter State_X_PrintedFlaskIdle;

		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		[FieldOffset(Offset = "0x2DAB0")]
		public static readonly AnimationParameter State_X_rockIdle;

		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		[FieldOffset(Offset = "0x2DAE0")]
		public static readonly AnimationParameter State_X_RunAggressive;

		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		[FieldOffset(Offset = "0x2DB10")]
		public static readonly AnimationParameter State_X_SeveredHeadEqup;

		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		[FieldOffset(Offset = "0x2DB40")]
		public static readonly AnimationParameter State_X_SeveredHeadIdle;

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x2DB70")]
		public static readonly AnimationParameter State_X_SeveredHeadScare;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0x2DBA0")]
		public static readonly AnimationParameter State_X_StickBreakAndPlace;

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x2DBD0")]
		public static readonly AnimationParameter State_X_StoneIdle;

		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		[FieldOffset(Offset = "0x2DC00")]
		public static readonly AnimationParameter State_X_swimIdle;

		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		[FieldOffset(Offset = "0x2DC30")]
		public static readonly AnimationParameter State_X_TarpIdle;

		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		[FieldOffset(Offset = "0x2DC60")]
		public static readonly AnimationParameter State_X_TurnAroundCombat;

		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		[FieldOffset(Offset = "0x2DC90")]
		public static readonly AnimationParameter State_X_WalkAggressive;

		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		[FieldOffset(Offset = "0x2DCC0")]
		public static readonly AnimationParameter State_X_WalkAggressiveToIdle;

		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		[FieldOffset(Offset = "0x2DCF0")]
		public static readonly AnimationParameter State_X_zipIdle;

		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		[FieldOffset(Offset = "0x2DD20")]
		public static readonly AnimationParameter State_YarroCraftHerbMix;

		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		[FieldOffset(Offset = "0x2DD50")]
		public static readonly AnimationParameter State_YarroIdle;

		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0x2DD80")]
		public static readonly AnimationParameter State_zipIdle;

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x2DDB0")]
		public static readonly AnimationParameter State_zipIdleUpwards;

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x2DDE0")]
		public static readonly AnimationParameter State_ZiplineIdle;

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x2DE10")]
		public static readonly AnimationParameter State_ZiplineRopeCraftZiplineRope;

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x2DE40")]
		public static readonly AnimationParameter State_ZiplineRopeIdle;

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0x2DE70")]
		public static readonly AnimationParameter Tag_aiming;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x2DEA0")]
		public static readonly AnimationParameter Tag_alerted;

		// Token: 0x04001066 RID: 4198
		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x2DED0")]
		public static readonly AnimationParameter Tag_assembleItem;

		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x2DF00")]
		public static readonly AnimationParameter Tag_attack;

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x2DF30")]
		public static readonly AnimationParameter Tag_attacking;

		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		[FieldOffset(Offset = "0x2DF60")]
		public static readonly AnimationParameter Tag_AttackWall;

		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x2DF90")]
		public static readonly AnimationParameter Tag_axeCombo1;

		// Token: 0x0400106B RID: 4203
		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0x2DFC0")]
		public static readonly AnimationParameter Tag_backAway;

		// Token: 0x0400106C RID: 4204
		[Token(Token = "0x400106C")]
		[FieldOffset(Offset = "0x2DFF0")]
		public static readonly AnimationParameter Tag_bashBody;

		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x2E020")]
		public static readonly AnimationParameter Tag_beckon;

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x2E050")]
		public static readonly AnimationParameter Tag_block;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x2E080")]
		public static readonly AnimationParameter Tag_blocking;

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x2E0B0")]
		public static readonly AnimationParameter Tag_bossIntro;

		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x2E0E0")]
		public static readonly AnimationParameter Tag_build;

		// Token: 0x04001072 RID: 4210
		[Token(Token = "0x4001072")]
		[FieldOffset(Offset = "0x2E110")]
		public static readonly AnimationParameter Tag_burning;

		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0x2E140")]
		public static readonly AnimationParameter Tag_CameraShakePassthrough;

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x2E170")]
		public static readonly AnimationParameter Tag_camping;

		// Token: 0x04001075 RID: 4213
		[Token(Token = "0x4001075")]
		[FieldOffset(Offset = "0x2E1A0")]
		public static readonly AnimationParameter Tag_checkArms;

		// Token: 0x04001076 RID: 4214
		[Token(Token = "0x4001076")]
		[FieldOffset(Offset = "0x2E1D0")]
		public static readonly AnimationParameter Tag_checkBody;

		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001077")]
		[FieldOffset(Offset = "0x2E200")]
		public static readonly AnimationParameter Tag_circling;

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x2E230")]
		public static readonly AnimationParameter Tag_clapping;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x2E260")]
		public static readonly AnimationParameter Tag_clear;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x2E290")]
		public static readonly AnimationParameter Tag_climbIdle;

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x2E2C0")]
		public static readonly AnimationParameter Tag_climbing;

		// Token: 0x0400107C RID: 4220
		[Token(Token = "0x400107C")]
		[FieldOffset(Offset = "0x2E2F0")]
		public static readonly AnimationParameter Tag_climbOut;

		// Token: 0x0400107D RID: 4221
		[Token(Token = "0x400107D")]
		[FieldOffset(Offset = "0x2E320")]
		public static readonly AnimationParameter Tag_coffinBreakout;

		// Token: 0x0400107E RID: 4222
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x2E350")]
		public static readonly AnimationParameter Tag_coffinIdle;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x2E380")]
		public static readonly AnimationParameter Tag_combo1;

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x2E3B0")]
		public static readonly AnimationParameter Tag_combo2;

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0x2E3E0")]
		public static readonly AnimationParameter Tag_counter;

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0x2E410")]
		public static readonly AnimationParameter Tag_cower;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0x2E440")]
		public static readonly AnimationParameter Tag_crouching;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		[FieldOffset(Offset = "0x2E470")]
		public static readonly AnimationParameter Tag_cutscene;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0x2E4A0")]
		public static readonly AnimationParameter Tag_dancing;

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x2E4D0")]
		public static readonly AnimationParameter Tag_Dead;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x2E500")]
		public static readonly AnimationParameter Tag_dead;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x2E530")]
		public static readonly AnimationParameter Tag_Death;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0x2E560")]
		public static readonly AnimationParameter Tag_death;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x2E590")]
		public static readonly AnimationParameter Tag_digging;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		[FieldOffset(Offset = "0x2E5C0")]
		public static readonly AnimationParameter Tag_DisallowLeftArm;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		[FieldOffset(Offset = "0x2E5F0")]
		public static readonly AnimationParameter Tag_dodging;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		[FieldOffset(Offset = "0x2E620")]
		public static readonly AnimationParameter Tag_dragged;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		[FieldOffset(Offset = "0x2E650")]
		public static readonly AnimationParameter Tag_dragging;

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		[FieldOffset(Offset = "0x2E680")]
		public static readonly AnimationParameter Tag_drinking;

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0x2E6B0")]
		public static readonly AnimationParameter Tag_drop;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0x2E6E0")]
		public static readonly AnimationParameter Tag_dropping;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0x2E710")]
		public static readonly AnimationParameter Tag_drowning;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0x2E740")]
		public static readonly AnimationParameter Tag_dying;

		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0x2E770")]
		public static readonly AnimationParameter Tag_eating;

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x2E7A0")]
		public static readonly AnimationParameter Tag_Electrocuted;

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0x2E7D0")]
		public static readonly AnimationParameter Tag_enterCave;

		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0x2E800")]
		public static readonly AnimationParameter Tag_enterClimb;

		// Token: 0x04001098 RID: 4248
		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0x2E830")]
		public static readonly AnimationParameter Tag_enterThrower;

		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x2E860")]
		public static readonly AnimationParameter Tag_explode;

		// Token: 0x0400109A RID: 4250
		[Token(Token = "0x400109A")]
		[FieldOffset(Offset = "0x2E890")]
		public static readonly AnimationParameter Tag_falling;

		// Token: 0x0400109B RID: 4251
		[Token(Token = "0x400109B")]
		[FieldOffset(Offset = "0x2E8C0")]
		public static readonly AnimationParameter Tag_fishing;

		// Token: 0x0400109C RID: 4252
		[Token(Token = "0x400109C")]
		[FieldOffset(Offset = "0x2E8F0")]
		public static readonly AnimationParameter Tag_flying;

		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x2E920")]
		public static readonly AnimationParameter Tag_gather;

		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x2E950")]
		public static readonly AnimationParameter Tag_getup;

		// Token: 0x0400109F RID: 4255
		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0x2E980")]
		public static readonly AnimationParameter Tag_hanging;

		// Token: 0x040010A0 RID: 4256
		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0x2E9B0")]
		public static readonly AnimationParameter Tag_held;

		// Token: 0x040010A1 RID: 4257
		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x2E9E0")]
		public static readonly AnimationParameter Tag_hiding;

		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x2EA10")]
		public static readonly AnimationParameter Tag_HitReaction;

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x2EA40")]
		public static readonly AnimationParameter Tag_hovering;

		// Token: 0x040010A4 RID: 4260
		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x2EA70")]
		public static readonly AnimationParameter Tag_hugPlayer;

		// Token: 0x040010A5 RID: 4261
		[Token(Token = "0x40010A5")]
		[FieldOffset(Offset = "0x2EAA0")]
		public static readonly AnimationParameter Tag_idle;

		// Token: 0x040010A6 RID: 4262
		[Token(Token = "0x40010A6")]
		[FieldOffset(Offset = "0x2EAD0")]
		public static readonly AnimationParameter Tag_idling;

		// Token: 0x040010A7 RID: 4263
		[Token(Token = "0x40010A7")]
		[FieldOffset(Offset = "0x2EB00")]
		public static readonly AnimationParameter Tag_inShell;

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x2EB30")]
		public static readonly AnimationParameter Tag_Interact;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x2EB60")]
		public static readonly AnimationParameter Tag_jumping;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x2EB90")]
		public static readonly AnimationParameter Tag_jumpOut;

		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x2EBC0")]
		public static readonly AnimationParameter Tag_knockBack;

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x2EBF0")]
		public static readonly AnimationParameter Tag_knockDown;

		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x2EC20")]
		public static readonly AnimationParameter Tag_LakeCrashPlayer;

		// Token: 0x040010AE RID: 4270
		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x2EC50")]
		public static readonly AnimationParameter Tag_land;

		// Token: 0x040010AF RID: 4271
		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x2EC80")]
		public static readonly AnimationParameter Tag_Land;

		// Token: 0x040010B0 RID: 4272
		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x2ECB0")]
		public static readonly AnimationParameter Tag_layEgg;

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x2ECE0")]
		public static readonly AnimationParameter Tag_lookAround;

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x2ED10")]
		public static readonly AnimationParameter Tag_looking;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x2ED40")]
		public static readonly AnimationParameter Tag_mournBody;

		// Token: 0x040010B4 RID: 4276
		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x2ED70")]
		public static readonly AnimationParameter Tag_noiseReact;

		// Token: 0x040010B5 RID: 4277
		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x2EDA0")]
		public static readonly AnimationParameter Tag_noLook;

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x2EDD0")]
		public static readonly AnimationParameter Tag_NONE;

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x2EE00")]
		public static readonly AnimationParameter Tag_nudge;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x2EE30")]
		public static readonly AnimationParameter Tag_onRock;

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		[FieldOffset(Offset = "0x2EE60")]
		public static readonly AnimationParameter Tag_onTree;

		// Token: 0x040010BA RID: 4282
		[Token(Token = "0x40010BA")]
		[FieldOffset(Offset = "0x2EE90")]
		public static readonly AnimationParameter Tag_openDoor;

		// Token: 0x040010BB RID: 4283
		[Token(Token = "0x40010BB")]
		[FieldOffset(Offset = "0x2EEC0")]
		public static readonly AnimationParameter Tag_parried;

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		[FieldOffset(Offset = "0x2EEF0")]
		public static readonly AnimationParameter Tag_passThrough;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x2EF20")]
		public static readonly AnimationParameter Tag_peek;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x2EF50")]
		public static readonly AnimationParameter Tag_pickup;

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0x2EF80")]
		public static readonly AnimationParameter Tag_pointing;

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x2EFB0")]
		public static readonly AnimationParameter Tag_praying;

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x2EFE0")]
		public static readonly AnimationParameter Tag_PutOnClothing;

		// Token: 0x040010C2 RID: 4290
		[Token(Token = "0x40010C2")]
		[FieldOffset(Offset = "0x2F010")]
		public static readonly AnimationParameter Tag_recovering;

		// Token: 0x040010C3 RID: 4291
		[Token(Token = "0x40010C3")]
		[FieldOffset(Offset = "0x2F040")]
		public static readonly AnimationParameter Tag_running;

		// Token: 0x040010C4 RID: 4292
		[Token(Token = "0x40010C4")]
		[FieldOffset(Offset = "0x2F070")]
		public static readonly AnimationParameter Tag_screaming;

		// Token: 0x040010C5 RID: 4293
		[Token(Token = "0x40010C5")]
		[FieldOffset(Offset = "0x2F0A0")]
		public static readonly AnimationParameter Tag_shellRide;

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0x2F0D0")]
		public static readonly AnimationParameter Tag_ShowAxe;

		// Token: 0x040010C7 RID: 4295
		[Token(Token = "0x40010C7")]
		[FieldOffset(Offset = "0x2F100")]
		public static readonly AnimationParameter Tag_sitting;

		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0x2F130")]
		public static readonly AnimationParameter Tag_slapFight;

		// Token: 0x040010C9 RID: 4297
		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x2F160")]
		public static readonly AnimationParameter Tag_sleeping;

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x2F190")]
		public static readonly AnimationParameter Tag_Slip;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x2F1C0")]
		public static readonly AnimationParameter Tag_smash;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x2F1F0")]
		public static readonly AnimationParameter Tag_SnowCrashPlayer;

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x2F220")]
		public static readonly AnimationParameter Tag_spawnActor;

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x2F250")]
		public static readonly AnimationParameter Tag_spawnIntro;

		// Token: 0x040010CF RID: 4303
		[Token(Token = "0x40010CF")]
		[FieldOffset(Offset = "0x2F280")]
		public static readonly AnimationParameter Tag_stepBack;

		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x2F2B0")]
		public static readonly AnimationParameter Tag_stepForward;

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x2F2E0")]
		public static readonly AnimationParameter Tag_stopping;

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x2F310")]
		public static readonly AnimationParameter Tag_strafing;

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x2F340")]
		public static readonly AnimationParameter Tag_struggle;

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x2F370")]
		public static readonly AnimationParameter Tag_swimming;

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x2F3A0")]
		public static readonly AnimationParameter Tag_takeoff;

		// Token: 0x040010D6 RID: 4310
		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x2F3D0")]
		public static readonly AnimationParameter Tag_Taunt;

		// Token: 0x040010D7 RID: 4311
		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x2F400")]
		public static readonly AnimationParameter Tag_throw;

		// Token: 0x040010D8 RID: 4312
		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x2F430")]
		public static readonly AnimationParameter Tag_thrower;

		// Token: 0x040010D9 RID: 4313
		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x2F460")]
		public static readonly AnimationParameter Tag_throwing;

		// Token: 0x040010DA RID: 4314
		[Token(Token = "0x40010DA")]
		[FieldOffset(Offset = "0x2F490")]
		public static readonly AnimationParameter Tag_TreeCrashPlayer;

		// Token: 0x040010DB RID: 4315
		[Token(Token = "0x40010DB")]
		[FieldOffset(Offset = "0x2F4C0")]
		public static readonly AnimationParameter Tag_treeJump;

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x2F4F0")]
		public static readonly AnimationParameter Tag_treeJumpAttack;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x2F520")]
		public static readonly AnimationParameter Tag_treeTaunt;

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x2F550")]
		public static readonly AnimationParameter Tag_trotting;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x2F580")]
		public static readonly AnimationParameter Tag_turning;

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x2F5B0")]
		public static readonly AnimationParameter Tag_waitForOrders;

		// Token: 0x040010E1 RID: 4321
		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x2F5E0")]
		public static readonly AnimationParameter Tag_walking;

		// Token: 0x040010E2 RID: 4322
		[Token(Token = "0x40010E2")]
		[FieldOffset(Offset = "0x2F610")]
		public static readonly AnimationParameter Tag_washing;

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x2F640")]
		public static readonly AnimationParameter Tag_yell;

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x2F670")]
		private static List<AnimationParameter> _all;

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x2F678")]
		private static List<AnimationParameter> _allParameters;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x2F680")]
		private static List<AnimationParameter> _allStates;

		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0x2F688")]
		private static List<AnimationParameter> _allLayers;

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x2F690")]
		private static List<AnimationParameter> _allTags;

		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		[FieldOffset(Offset = "0x2F698")]
		private static List<AnimationParameter> _allStatesAndTags;
	}
}
