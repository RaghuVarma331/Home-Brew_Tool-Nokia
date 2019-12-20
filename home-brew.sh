#!/bin/bash
#
# RAGHU VARMA Build Script 
# Coded by RV 
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

clear

# Init Fields

Telegram_Api_code=
securitypatch=2019-07-05
androidversion=9.0
buildnumber=354H
DRG=https://android.googleapis.com/packages/ota-api/nokia_drgsprout_dragon00ww/810351d123009ec07c1cb5857c4707fdeba776ef.zip
B2N=https://android.googleapis.com/packages/ota-api/nokia_b2nsprout_onyx00ww/3f78de06f86cc03da028648341aa1987fe33b2df.zip
PL2=https://android.googleapis.com/packages/ota-api/nokia_pl2sprout_plate200ww/be7e54518410d1752dd72f99dba3aecdee793bdb.zip
CTL=https://android.googleapis.com/packages/ota-api/nokia_ctlsprout_crystal00ww/b708f828b774c5d737530f3d1ea200db7a918308.zip
password=
path=

# Init Methods

DRG()
{
    mkdir DRG
    cd DRG
    wget $DRG
    unzip *
    mkdir payload
    mkdir output
    cp -r payload.bin $path/DRG/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    mv abl.img          DRG-$buildnumber-0-00WW-B01-abl.img
    mv bluetooth.img    DRG-$buildnumber-0-00WW-B01-bluetooth.img
    mv boot.img         DRG-$buildnumber-0-00WW-B01-boot.img
    mv cda.img          DRG-$buildnumber-0-00WW-B01-cda.img
    mv cmnlib.img       DRG-$buildnumber-0-00WW-B01-cmnlib.img
    mv cmnlib64.img     DRG-$buildnumber-0-00WW-B01-cmnlib64.img
    mv devcfg.img       DRG-$buildnumber-0-00WW-B01-devcfg.img
    mv dsp.img          DRG-$buildnumber-0-00WW-B01-dsp.img
    mv hidden.img       DRG-$buildnumber-0-00WW-B01-hidden.img
    mv hyp.img          DRG-$buildnumber-0-00WW-B01-hyp.img
    mv keymaster.img    DRG-$buildnumber-0-00WW-B01-keymaster.img
    mv mdtp.img         DRG-$buildnumber-0-00WW-B01-mdtp.img
    mv mdtpsecapp.img   DRG-$buildnumber-0-00WW-B01-mdtpsecapp.img
    mv modem.img        DRG-$buildnumber-0-00WW-B01-modem.img
    mv nvdef.img        DRG-$buildnumber-0-00WW-B01-nvdef.img
    mv pmic.img         DRG-$buildnumber-0-00WW-B01-pmic.img
    mv rpm.img          DRG-$buildnumber-0-00WW-B01-rpm.img
    mv splash.img       DRG-$buildnumber-0-00WW-B01-splash.img
    mv systeminfo.img   DRG-$buildnumber-0-00WW-B01-systeminfo.img
    mv tz.img           DRG-$buildnumber-0-00WW-B01-tz.img
    mv xbl.img          DRG-$buildnumber-0-00WW-B01-xbl.img
    ./img2simg system.img DRG-$buildnumber-0-00WW-B01-system.img
    ./img2simg vendor.img DRG-$buildnumber-0-00WW-B01-vendor.img
    rm -r payload.bin payload_dumper.py update_metadata_pb2.py update_metadata_pb2.pyc simg2img img2simg vendor.img system.img 
    zip -r DRG-$buildnumber-0-00WW-B01-$androidversion-HB.zip *
    cp -r DRG-$buildnumber-0-00WW-B01-$androidversion-HB.zip $path/DRG/output
    cd
    cd $path/DRG/output
    sshpass -p $password rsync -avP -e ssh DRG-$buildnumber-0-00WW-B01-$androidversion-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/drg-sprout/STOCK-ROMS
    cd
    cd $path    
    wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @Nokia6plusofficial -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/drg-sprout/files/STOCK-ROMS/DRG-$buildnumber-0-00WW-B01-$androidversion-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Stock-Rom_Flash-Tool_Nokia/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 6.1 Plus*
    ⚡Build Version: *DRG-$buildnumber-0-00WW-B01*
    ⚡Android Version: *$androidversion*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @Nokia6plusofficial ✅" 
}    

B2N()
{
    mkdir B2N
    cd B2N
    wget $B2N
    unzip *
    mkdir payload
    mkdir output
    cp -r payload.bin $path/B2N/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    mv abl.img          B2N-$buildnumber-0-00WW-B01-abl.img
    mv bluetooth.img    B2N-$buildnumber-0-00WW-B01-bluetooth.img
    mv boot.img         B2N-$buildnumber-0-00WW-B01-boot.img
    mv cda.img          B2N-$buildnumber-0-00WW-B01-cda.img
    mv cmnlib.img       B2N-$buildnumber-0-00WW-B01-cmnlib.img
    mv cmnlib64.img     B2N-$buildnumber-0-00WW-B01-cmnlib64.img
    mv devcfg.img       B2N-$buildnumber-0-00WW-B01-devcfg.img
    mv dsp.img          B2N-$buildnumber-0-00WW-B01-dsp.img
    mv hidden.img       B2N-$buildnumber-0-00WW-B01-hidden.img
    mv hyp.img          B2N-$buildnumber-0-00WW-B01-hyp.img
    mv keymaster.img    B2N-$buildnumber-0-00WW-B01-keymaster.img
    mv mdtp.img         B2N-$buildnumber-0-00WW-B01-mdtp.img
    mv mdtpsecapp.img   B2N-$buildnumber-0-00WW-B01-mdtpsecapp.img
    mv modem.img        B2N-$buildnumber-0-00WW-B01-modem.img
    mv nvdef.img        B2N-$buildnumber-0-00WW-B01-nvdef.img
    mv pmic.img         B2N-$buildnumber-0-00WW-B01-pmic.img
    mv rpm.img          B2N-$buildnumber-0-00WW-B01-rpm.img
    mv splash.img       B2N-$buildnumber-0-00WW-B01-splash.img
    mv systeminfo.img   B2N-$buildnumber-0-00WW-B01-systeminfo.img
    mv tz.img           B2N-$buildnumber-0-00WW-B01-tz.img
    mv xbl.img          B2N-$buildnumber-0-00WW-B01-xbl.img
    ./img2simg system.img B2N-$buildnumber-0-00WW-B01-system.img
    ./img2simg vendor.img B2N-$buildnumber-0-00WW-B01-vendor.img
    rm -r payload.bin payload_dumper.py update_metadata_pb2.py update_metadata_pb2.pyc simg2img img2simg vendor.img system.img 
    zip -r B2N-$buildnumber-0-00WW-B01-$androidversion-HB.zip *
    cp -r B2N-$buildnumber-0-00WW-B01-$androidversion-HB.zip $path/B2N/output
    cd
    cd $path/B2N/output
    sshpass -p $password rsync -avP -e ssh B2N-$buildnumber-0-00WW-B01-$androidversion-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/b2n-sprout/STOCK-ROMS
    cd
    cd $path    
    wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @Nokia7plusOfficial -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/b2n-sprout/files/STOCK-ROMS/B2N-$buildnumber-0-00WW-B01-$androidversion-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Stock-Rom_Flash-Tool_Nokia/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 7 Plus*
    ⚡Build Version: *B2N-$buildnumber-0-00WW-B01*
    ⚡Android Version: *$androidversion*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @Nokia7plusOfficial ✅" 
}  

PL2()
{
    mkdir PL2
    cd PL2
    wget $PL2
    unzip *
    mkdir payload
    mkdir output
    cp -r payload.bin $path/PL2/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    mv abl.img          PL2-$buildnumber-0-00WW-B01-abl.img
    mv bluetooth.img    PL2-$buildnumber-0-00WW-B01-bluetooth.img
    mv boot.img         PL2-$buildnumber-0-00WW-B01-boot.img
    mv cda.img          PL2-$buildnumber-0-00WW-B01-cda.img
    mv cmnlib.img       PL2-$buildnumber-0-00WW-B01-cmnlib.img
    mv cmnlib64.img     PL2-$buildnumber-0-00WW-B01-cmnlib64.img
    mv devcfg.img       PL2-$buildnumber-0-00WW-B01-devcfg.img
    mv dsp.img          PL2-$buildnumber-0-00WW-B01-dsp.img
    mv hidden.img       PL2-$buildnumber-0-00WW-B01-hidden.img
    mv hyp.img          PL2-$buildnumber-0-00WW-B01-hyp.img
    mv keymaster.img    PL2-$buildnumber-0-00WW-B01-keymaster.img
    mv mdtp.img         PL2-$buildnumber-0-00WW-B01-mdtp.img
    mv mdtpsecapp.img   PL2-$buildnumber-0-00WW-B01-mdtpsecapp.img
    mv modem.img        PL2-$buildnumber-0-00WW-B01-modem.img
    mv nvdef.img        PL2-$buildnumber-0-00WW-B01-nvdef.img
    mv pmic.img         PL2-$buildnumber-0-00WW-B01-pmic.img
    mv rpm.img          PL2-$buildnumber-0-00WW-B01-rpm.img
    mv splash.img       PL2-$buildnumber-0-00WW-B01-splash.img
    mv systeminfo.img   PL2-$buildnumber-0-00WW-B01-systeminfo.img
    mv tz.img           PL2-$buildnumber-0-00WW-B01-tz.img
    mv xbl.img          PL2-$buildnumber-0-00WW-B01-xbl.img
    ./img2simg system.img PL2-$buildnumber-0-00WW-B01-system.img
    ./img2simg vendor.img PL2-$buildnumber-0-00WW-B01-vendor.img
    rm -r payload.bin payload_dumper.py update_metadata_pb2.py update_metadata_pb2.pyc simg2img img2simg vendor.img system.img 
    zip -r PL2-$buildnumber-0-00WW-B01-$androidversion-HB.zip *
    cp -r PL2-$buildnumber-0-00WW-B01-$androidversion-HB.zip $path/PL2/output
    cd
    cd $path/PL2/output
    sshpass -p $password rsync -avP -e ssh PL2-$buildnumber-0-00WW-B01-$androidversion-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/pl2-sprout/STOCK-ROMS
    cd
    cd $path    
    wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @nokia7161 -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/pl2-sprout/files/STOCK-ROMS/PL2-$buildnumber-0-00WW-B01-$androidversion-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Stock-Rom_Flash-Tool_Nokia/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 6.1*
    ⚡Build Version: *PL2-$buildnumber-0-00WW-B01*
    ⚡Android Version: *$androidversion*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @nokia7161 ✅" 
}  

CTL()
{
    mkdir CTL
    cd CTL
    wget $CTL
    unzip *
    mkdir payload
    mkdir output
    cp -r payload.bin $path/CTL/payload
    cd payload
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
    wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
    chmod a+x payload_dumper.py
    chmod a+x update_metadata_pb2.py
    chmod a+x simg2img
    chmod a+x img2simg
    ./payload_dumper.py payload.bin 
    mv abl.img          CTL-$buildnumber-0-00WW-B01-abl.img
    mv bluetooth.img    CTL-$buildnumber-0-00WW-B01-bluetooth.img
    mv boot.img         CTL-$buildnumber-0-00WW-B01-boot.img
    mv cda.img          CTL-$buildnumber-0-00WW-B01-cda.img
    mv cmnlib.img       CTL-$buildnumber-0-00WW-B01-cmnlib.img
    mv cmnlib64.img     CTL-$buildnumber-0-00WW-B01-cmnlib64.img
    mv devcfg.img       CTL-$buildnumber-0-00WW-B01-devcfg.img
    mv dsp.img          CTL-$buildnumber-0-00WW-B01-dsp.img
    mv hidden.img       CTL-$buildnumber-0-00WW-B01-hidden.img
    mv hyp.img          CTL-$buildnumber-0-00WW-B01-hyp.img
    mv keymaster.img    CTL-$buildnumber-0-00WW-B01-keymaster.img
    mv mdtp.img         CTL-$buildnumber-0-00WW-B01-mdtp.img
    mv mdtpsecapp.img   CTL-$buildnumber-0-00WW-B01-mdtpsecapp.img
    mv modem.img        CTL-$buildnumber-0-00WW-B01-modem.img
    mv nvdef.img        CTL-$buildnumber-0-00WW-B01-nvdef.img
    mv pmic.img         CTL-$buildnumber-0-00WW-B01-pmic.img
    mv rpm.img          CTL-$buildnumber-0-00WW-B01-rpm.img
    mv splash.img       CTL-$buildnumber-0-00WW-B01-splash.img
    mv systeminfo.img   CTL-$buildnumber-0-00WW-B01-systeminfo.img
    mv tz.img           CTL-$buildnumber-0-00WW-B01-tz.img
    mv xbl.img          CTL-$buildnumber-0-00WW-B01-xbl.img
    ./img2simg system.img CTL-$buildnumber-0-00WW-B01-system.img
    ./img2simg vendor.img CTL-$buildnumber-0-00WW-B01-vendor.img
    rm -r payload.bin payload_dumper.py update_metadata_pb2.py update_metadata_pb2.pyc simg2img img2simg vendor.img system.img 
    zip -r CTL-$buildnumber-0-00WW-B01-$androidversion-HB.zip *
    cp -r CTL-$buildnumber-0-00WW-B01-$androidversion-HB.zip $path/CTL/output
    cd
    cd $path/CTL/output
    sshpass -p $password rsync -avP -e ssh CTL-$buildnumber-0-00WW-B01-$androidversion-HB.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/ctl-sprout/STOCK-ROMS
    cd
    cd $path    
    wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
    wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
    python telegram.py -t $Telegram_Api_code -c @nokia7161 -P image.png -C " 
    *
    New Home Brew Stock Rom 
    Release is Up
    
    $(date)*
    
    ⬇️ [Download Rom](https://sourceforge.net/projects/ctl-sprout/files/STOCK-ROMS/CTL-$buildnumber-0-00WW-B01-$androidversion-HB.zip/download) 
    🔨 [Download flash tool](https://github.com/RaghuVarma331/Stock-Rom_Flash-Tool_Nokia/releases)
    💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/hbinstallation.txt)
    📱 Device: *Nokia 7.1*
    ⚡Build Version: *CTL-$buildnumber-0-00WW-B01*
    ⚡Android Version: *$androidversion*
    ⚡Google Security Patch : *$securitypatch*
    👤 By: *Raghu Varma*
    #OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
    Follow: @nokia7161 ✅" 
} 

# Main Menu
clear
echo "-----------------------------------------------------------"
echo "A simple tool to make home brew stock rom from Full OTA.zip"
echo "Coded By Raghu Varma.G "
echo "-----------------------------------------------------------"
PS3='Please select your option (1-4): '
menuvar=("DRG" "B2N" "CTL" "PL2" "Exit")
select menuvar in "${menuvar[@]}"
do
    case $menuvar in
        "DRG")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # DRG
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            DRG
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	    
        "B2N")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # B2N
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            B2N
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	
        "PL2")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # PL2
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            PL2
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;	
        "CTL")
            clear
            echo "----------------------------------------------"           
            echo "Please be patient..."
            # CTL
            echo "----------------------------------------------"
            echo "Posting in channel..."
            echo " "
            CTL
	    echo " "	    
            echo "----------------------------------------------"
            echo "Posting in Channel finished."
            echo " "
            echo "----------------------------------------------"
            echo "Press any key for end the script."
            echo "----------------------------------------------"
            read -n1 -r key
            break
            ;;		    
        "Exit")
            break
            ;;
        *) echo Invalid option.;;
    esac
done   
            
