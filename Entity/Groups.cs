using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkBuddies.Entity
{
    /// <summary>
    /// CREATE TABLE `Groups` (
    ///`idGroups` int(11) NOT NULL,
    ///`idGroup` int(11) NOT NULL,
    ///`idFriend` int(11) NOT NULL,
    ///PRIMARY KEY(`idGroups`) USING BTREE,
    ///KEY `FK_Groups_Friends_1` (`idFriend`),
    ///KEY `FK_Groups_Group` (`idGroup`),
    ///CONSTRAINT `FK_Groups_Friends_1` FOREIGN KEY(`idFriend`) REFERENCES `Friends` (`idFriend`) ON DELETE NO ACTION ON UPDATE NO ACTION,
    ///CONSTRAINT `FK_Groups_Group` FOREIGN KEY(`idGroup`) REFERENCES `Group` (`idGroup`) ON DELETE NO ACTION ON UPDATE NO ACTION
    ///) ENGINE=InnoDB DEFAULT CHARSET=latin1;
    /// </summary>
    class Groups
    {
        /// <summary>
        /// Primary key for the groups
        /// </summary>
        int idGroups { get; set; }

        /// <summary>
        /// Foreign key of the group
        /// </summary>
        int idGroup { get; set; }

        /// <summary>
        /// Foreign key of the friend
        /// </summary>
        int idFriend { get; set; }
    }
}
