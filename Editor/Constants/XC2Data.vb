﻿''' <summary>
''' Information required to read an bayo1 save file.
''' </summary>
Public Class XC2Data
    Public Shared PlayerInfoOffsets As New Dictionary(Of XC2DataType, HexDataInfo) From {
        {XC2DataType.Rupees, New HexDataInfo With {.Offset = &H2B8, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_1, New HexDataInfo With {.Offset = &H1AFE, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_2, New HexDataInfo With {.Offset = &H1B00, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_3, New HexDataInfo With {.Offset = &H1B02, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_4, New HexDataInfo With {.Offset = &H1B04, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_5, New HexDataInfo With {.Offset = &H1B06, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_6, New HexDataInfo With {.Offset = &H1B08, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_7, New HexDataInfo With {.Offset = &H1B0A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_8, New HexDataInfo With {.Offset = &H1B0C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_9, New HexDataInfo With {.Offset = &H1B0E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_10, New HexDataInfo With {.Offset = &H1B10, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_11, New HexDataInfo With {.Offset = &H1B12, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_12, New HexDataInfo With {.Offset = &H1B14, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_13, New HexDataInfo With {.Offset = &H1B16, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_14, New HexDataInfo With {.Offset = &H1B18, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_15, New HexDataInfo With {.Offset = &H1B1A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_16, New HexDataInfo With {.Offset = &H1B1C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_17, New HexDataInfo With {.Offset = &H1B1E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_18, New HexDataInfo With {.Offset = &H1B20, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_19, New HexDataInfo With {.Offset = &H1B22, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_20, New HexDataInfo With {.Offset = &H1B24, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_21, New HexDataInfo With {.Offset = &H1B26, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_22, New HexDataInfo With {.Offset = &H1B28, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_23, New HexDataInfo With {.Offset = &H1B2A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_24, New HexDataInfo With {.Offset = &H1B2C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_25, New HexDataInfo With {.Offset = &H1B2E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_26, New HexDataInfo With {.Offset = &H1B30, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_27, New HexDataInfo With {.Offset = &H1B32, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_28, New HexDataInfo With {.Offset = &H1B34, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_29, New HexDataInfo With {.Offset = &H1B36, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_30, New HexDataInfo With {.Offset = &H1B38, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_31, New HexDataInfo With {.Offset = &H1B3A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_32, New HexDataInfo With {.Offset = &H1B3C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_33, New HexDataInfo With {.Offset = &H1B3E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_34, New HexDataInfo With {.Offset = &H1B40, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_35, New HexDataInfo With {.Offset = &H1B42, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_36, New HexDataInfo With {.Offset = &H1B44, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_37, New HexDataInfo With {.Offset = &H1B46, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_38, New HexDataInfo With {.Offset = &H1B48, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_39, New HexDataInfo With {.Offset = &H1B4A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_40, New HexDataInfo With {.Offset = &H1B4C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_41, New HexDataInfo With {.Offset = &H1B4E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_42, New HexDataInfo With {.Offset = &H1B50, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_43, New HexDataInfo With {.Offset = &H1B52, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_44, New HexDataInfo With {.Offset = &H1B56, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_45, New HexDataInfo With {.Offset = &H1B58, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_46, New HexDataInfo With {.Offset = &H1B5A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_47, New HexDataInfo With {.Offset = &H1B5C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_48, New HexDataInfo With {.Offset = &H1B5E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_49, New HexDataInfo With {.Offset = &H1B60, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_50, New HexDataInfo With {.Offset = &H1B62, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_51, New HexDataInfo With {.Offset = &H1B66, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_52, New HexDataInfo With {.Offset = &H1B68, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_53, New HexDataInfo With {.Offset = &H1B6A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_54, New HexDataInfo With {.Offset = &H1B6C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_55, New HexDataInfo With {.Offset = &H1B6E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_56, New HexDataInfo With {.Offset = &H1B70, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_57, New HexDataInfo With {.Offset = &H1B72, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_58, New HexDataInfo With {.Offset = &H1B74, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_59, New HexDataInfo With {.Offset = &H1B76, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_60, New HexDataInfo With {.Offset = &H1B78, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_61, New HexDataInfo With {.Offset = &H1B7A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_62, New HexDataInfo With {.Offset = &H1B7C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_63, New HexDataInfo With {.Offset = &H1B7E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_64, New HexDataInfo With {.Offset = &H1B80, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_65, New HexDataInfo With {.Offset = &H1B82, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_66, New HexDataInfo With {.Offset = &H1B84, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_67, New HexDataInfo With {.Offset = &H1B86, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_68, New HexDataInfo With {.Offset = &H1B88, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_69, New HexDataInfo With {.Offset = &H1B84, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_70, New HexDataInfo With {.Offset = &H1B86, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_71, New HexDataInfo With {.Offset = &H1B88, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_72, New HexDataInfo With {.Offset = &H1B8A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_73, New HexDataInfo With {.Offset = &H1B8C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_74, New HexDataInfo With {.Offset = &H1B8E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_75, New HexDataInfo With {.Offset = &H1B92, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_76, New HexDataInfo With {.Offset = &H1B94, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_77, New HexDataInfo With {.Offset = &H1B96, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_78, New HexDataInfo With {.Offset = &H1B98, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_79, New HexDataInfo With {.Offset = &H1B9A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_80, New HexDataInfo With {.Offset = &H1B9C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_81, New HexDataInfo With {.Offset = &H1B9E, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_82, New HexDataInfo With {.Offset = &H1BA0, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_83, New HexDataInfo With {.Offset = &H1BA2, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_84, New HexDataInfo With {.Offset = &H1BA4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_85, New HexDataInfo With {.Offset = &H1BA6, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_86, New HexDataInfo With {.Offset = &H1BA8, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_87, New HexDataInfo With {.Offset = &H1BAA, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_88, New HexDataInfo With {.Offset = &H1BAC, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_89, New HexDataInfo With {.Offset = &H1BAE, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_90, New HexDataInfo With {.Offset = &H1BB0, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_91, New HexDataInfo With {.Offset = &H1BB2, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_92, New HexDataInfo With {.Offset = &H1BB4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_93, New HexDataInfo With {.Offset = &H1BB6, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_94, New HexDataInfo With {.Offset = &H1BB8, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Materials_95, New HexDataInfo With {.Offset = &H1BBA, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Weapon_ID, New HexDataInfo With {.Offset = &H33804, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Weapon_Strength, New HexDataInfo With {.Offset = &H33806, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Weapon_Level, New HexDataInfo With {.Offset = &H33808, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Weapon_Skill, New HexDataInfo With {.Offset = &H3380A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Weapon_Set_As_03, New HexDataInfo With {.Offset = &H33804, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
    }
    '''    {XC2DataType.Character_1, New HexDataInfo With {.Offset = &H3308C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_2, New HexDataInfo With {.Offset = &H330BC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_3, New HexDataInfo With {.Offset = &H330EC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_4, New HexDataInfo With {.Offset = &H3311C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_5, New HexDataInfo With {.Offset = &H3314C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''   {XC2DataType.Character_6, New HexDataInfo With {.Offset = &H3317C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''   {XC2DataType.Character_7, New HexDataInfo With {.Offset = &H331AC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_8, New HexDataInfo With {.Offset = &H331DC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_9, New HexDataInfo With {.Offset = &H3320C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_10, New HexDataInfo With {.Offset = &H3323C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_11, New HexDataInfo With {.Offset = &H3326C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_12, New HexDataInfo With {.Offset = &H3329C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_13, New HexDataInfo With {.Offset = &H332CC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_14, New HexDataInfo With {.Offset = &H332FC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_15, New HexDataInfo With {.Offset = &H3332C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_16, New HexDataInfo With {.Offset = &H3335C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_17, New HexDataInfo With {.Offset = &H3338C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_18, New HexDataInfo With {.Offset = &H333BC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_19, New HexDataInfo With {.Offset = &H333EC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_20, New HexDataInfo With {.Offset = &H3347C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_21, New HexDataInfo With {.Offset = &H334AC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_22, New HexDataInfo With {.Offset = &H334DC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_23, New HexDataInfo With {.Offset = &H3350C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''     {XC2DataType.Character_24, New HexDataInfo With {.Offset = &H3353C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_25, New HexDataInfo With {.Offset = &H3356C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_26, New HexDataInfo With {.Offset = &H3359C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''    {XC2DataType.Character_27, New HexDataInfo With {.Offset = &H335CC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''   {XC2DataType.Character_28, New HexDataInfo With {.Offset = &H335FC, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    '''  {XC2DataType.Character_29, New HexDataInfo With {.Offset = &H3362C, .Size = &H6, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}




End Class
